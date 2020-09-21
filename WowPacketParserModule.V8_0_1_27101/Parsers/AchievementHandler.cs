using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;
using WowPacketParser.DBC;
using System.Collections.Generic;

namespace WowPacketParserModule.V8_0_1_27101.Parsers
{
    public static class AchievementHandler
    {
        public static Dictionary<int, ulong> FactionReputationStore { get; } = new Dictionary<int, ulong>();

        [Parser(Opcode.SMSG_CRITERIA_UPDATE)]
        public static void HandleCriteriaPlayer(Packet packet)
        {
            int criteriaId = packet.ReadInt32<CriteriaId>("CriteriaID");
            ulong quantity = (ulong)packet.ReadInt64("Quantity");
            packet.ReadPackedGuid128("PlayerGUID");
            packet.ReadInt32("Flags");
            packet.ReadPackedTime("CurrentTime");
            packet.ReadTime("ElapsedTime");
            packet.ReadTime("CreationTime");

            var hasRafAcceptanceID = false;
            if (ClientVersion.AddedInVersion(ClientVersionBuild.V8_2_5_31921))
                hasRafAcceptanceID = packet.ReadBit();

            if (hasRafAcceptanceID)
                packet.ReadUInt64_Sanitize("RafAcceptanceID");

            if (Settings.UseDBC)
                if (DBC.Criteria.ContainsKey(criteriaId))
                    if (DBC.Criteria[criteriaId].Type == 46)
                        FactionReputationStore[DBC.Criteria[criteriaId].Asset] = quantity;
        }
    }
}

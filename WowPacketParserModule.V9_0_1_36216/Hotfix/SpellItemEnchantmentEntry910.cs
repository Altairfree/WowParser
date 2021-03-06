using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V9_1_0_39185.Hotfix
{
    [HotfixStructure(DB2Hash.SpellItemEnchantment, ClientVersionBuild.V9_1_0_39185, HasIndexInData = false)]
    public class SpellItemEnchantmentEntry
    {
        public string Name { get; set; }
        public string HordeName { get; set; }
        [HotfixArray(3)]
        public uint[] EffectArg { get; set; }
        [HotfixArray(3)]
        public float[] EffectScalingPoints { get; set; }
        public uint IconFileDataID { get; set; }
        public int MinItemLevel { get; set; }
        public int MaxItemLevel { get; set; }
        public uint TransmogUseConditionID { get; set; }
        public uint TransmogCost { get; set; }
        [HotfixArray(3)]
        public short[] EffectPointsMin { get; set; }
        public ushort ItemVisual { get; set; }
        public ushort Flags { get; set; }
        public ushort RequiredSkillID { get; set; }
        public ushort RequiredSkillRank { get; set; }
        public ushort ItemLevel { get; set; }
        public byte Charges { get; set; }
        [HotfixArray(3)]
        public byte[] Effect { get; set; }
        public sbyte ScalingClass { get; set; }
        public sbyte ScalingClassRestricted { get; set; }
        public byte ConditionID { get; set; }
        public byte MinLevel { get; set; }
        public byte MaxLevel { get; set; }
    }
}

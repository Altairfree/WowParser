using WowPacketParser.Store.Objects.UpdateFields;

// This file is automatically generated, DO NOT EDIT

namespace WowPacketParserModule.V9_0_1_36216.UpdateFields.V9_0_5_37862
{
    public class QuestLog : IQuestLog
    {
        public int QuestID { get; set; }
        public uint StateFlags { get; set; }
        public uint EndTime { get; set; }
        public uint AcceptTime { get; set; }
        public uint ObjectiveFlags { get; set; }
        public short[] ObjectiveProgress { get; } = new short[24];
    }
}


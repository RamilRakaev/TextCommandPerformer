namespace TextCommandPerformer.Models
{
    class TextCommand
    {
        public string StartOperator { get; set; }

        public Dictionary<string, DataType> IntermediateOperators { get; set; }

        public string EndOperator { get; set; }
    }
}

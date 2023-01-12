using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using TextCommandPerformer.Models;

namespace TextCommandPerformer
{
    partial class Performer
    {
        private const string _commandsPath = "Commands";
        private readonly List<TextCommand> _commands;

        public Performer()
        {
            _commands = new();
            var path = Path.Combine(Directory.GetCurrentDirectory(), _commandsPath);
            foreach (var filePath in Directory.GetFiles(path))
            {
                var text = File.ReadAllText(filePath, Encoding.Default);
                _commands.Add(JsonSerializer.Deserialize<TextCommand>(text));
            }
        }

        public void Perform(string text)
        {
            var data = Recognizer(text);
            var result = ProcessData(data);
        }

        private Dictionary<string, DataType> Recognizer(string text)
        {
            text = text.ToLower();
            var textCommand = _commands.First(command => text.Contains(command.StartOperator));

            var endIndex = text.LastIndexOf(textCommand.EndOperator);

            var operators = textCommand.IntermediateOperators
                .Select(op => new
                {
                    Name = op.Key.Split('|').First(currentOperator => text.Contains(currentOperator)),
                    Type = op.Value
                })
                .ToDictionary(op => op.Name, op => op.Type);

            int[] indexes = operators
                .Select(op => text.LastIndexOf(op.Key))
                .ToArray();

            Dictionary<string, DataType> data = new(20);

            for (int i = 0; i < indexes.Length - 1; i++)
            {
                var indermediateText = text[indexes[i]..indexes[i + 1]]
                    .Replace(operators.ElementAt(i).Key, "");

                data.Add(indermediateText, operators.ElementAt(i).Value);
            }
            var endingText = text[indexes.LastOrDefault()..endIndex];
            data.Add(endingText.Replace(operators.Last().Key, ""), operators.Last().Value);

            return data;
        }

        private List<string> ProcessData(Dictionary<string, DataType> data)
        {
            return data.Select(variable => ConvertData(variable.Key, variable.Value)).ToList();
        }

        private string ConvertData(string data, DataType dataType)
        {
            switch (dataType)
            {
                case DataType.Number:
                    Regex regex = NumberRegex();
                    var val = regex.Match(data).Value;
                    return val;
                default:
                    return data;
            }
        }

        [GeneratedRegex("\\d*.?\\d*")]
        private partial Regex NumberRegex();
    }
}

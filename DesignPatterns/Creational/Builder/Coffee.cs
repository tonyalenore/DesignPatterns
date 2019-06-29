using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public class Coffee
    {
        private readonly Dictionary<string, string> _options = new Dictionary<string, string>();

        public string this[string key]
        {
            get => _options[key];
            set => _options[key] = value;
        }

        public string ShowOptions()
        {
            if (_options.Any())
            {
                var sb = new StringBuilder();

                foreach (var option in _options)
                {
                    sb.AppendLine($"{option.Key} - {option.Value}");
                }

                return sb.ToString();
            }
            return string.Empty;
        }
    }
}
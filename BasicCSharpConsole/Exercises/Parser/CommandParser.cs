using System.Collections.Generic;
using System.Linq;

namespace BasicCSharpConsole.Exercises.Parser
{
    public class CommandParser
    {
        public Dictionary<string, string> Parameters { get; } // parameterName=parameterValue
        public List<string> Switches { get; } // -switchName
        public List<string> OtherParameters { get; }

        public CommandParser(string[] args)
        {
            Parameters = new Dictionary<string, string>();
            Switches = new List<string>();
            OtherParameters = new List<string>();
            ParseCommandLineArguments(args);
        }

        public string GetParameterValue(string parameterName)
        {
            return Parameters.ContainsKey(parameterName)
                ? Parameters[parameterName]
                : string.Empty;
        }

        public bool HasSwitch(string switchName)
        {
            return Switches.Contains(switchName);
        }

        private void ParseCommandLineArguments(string[] args)
        {
            foreach (var arg in args)
            {
                if (arg.Contains('='))
                {
                    var arr = arg.Split('=');
                    Parameters.Add(arr[0], arr[1]);
                }
                else if (arg.StartsWith("-"))
                {
                    Switches.Add(arg.Substring(1));
                }
                else
                {
                    OtherParameters.Add(arg);
                }
            }
        }
    }
}

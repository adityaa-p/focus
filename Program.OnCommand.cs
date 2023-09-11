using System;
using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using System.Linq;
using System.Threading;

namespace Focus
{
    static partial class Program
    {
        private static Command CreateOnCommand()
        {
            var command = new Command("on", "focus mode on - block all social media sites")
            {
                new Option("--all")
                {
                    Description = "Block all social media websites",
                    Required = false
                },
            };

            command.Handler = CommandHandler.Create<OnCommandArguments>(async args =>
            {
                Console.WriteLine("on command executing");


            });

            return command;
        }

        private class OnCommandArguments
        {
            public IConsole Console { get; set; } = default!;

            public bool Dashboard { get; set; }

            public string[] Debug { get; set; } = Array.Empty<string>();

            public string Dtrace { get; set; } = default!;

            public bool Docker { get; set; }

            public string Logs { get; set; } = default!;

            public string Metrics { get; set; } = default!;

            public bool NoBuild { get; set; }

            public FileInfo Path { get; set; } = default!;

            public int? Port { get; set; }

            public bool Watch { get; set; }

            public string Framework { get; set; } = default!;

            public string[] Tags { get; set; } = Array.Empty<string>();
        }
    }
}
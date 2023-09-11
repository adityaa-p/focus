
using System.CommandLine;
using System.CommandLine.Builder;
using System.CommandLine.Parsing;

namespace Focus;

public partial class Program
{
    public static Task<int> Main(string[] args)
    {
        var command = new RootCommand()
        {
            Description = "A CLI tool to keep you focused during work hours"
        };

        command.AddCommand(CreateOnCommand());

        var builder = new CommandLineBuilder(command);

        var parser = builder.Build();
        return parser.InvokeAsync(args);
    }
}
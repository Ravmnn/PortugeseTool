using System.CommandLine;


namespace PortugueseTool;


class Program
{
    public static int Main(string[] args)
    {
        var root = new RootCommand("CLI tool for analyzing portuguese text.");

        var parseResult = root.Parse(args);

        foreach (var parseError in parseResult.Errors)
        {
            Console.WriteLine(parseError.Message);
            return 1;
        }

        return parseResult.Invoke();
    }
}

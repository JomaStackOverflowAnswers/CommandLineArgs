using Microsoft.Extensions.Configuration;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("██ SecondaryApp Started");
        string settingsFile = args.Where(a => a.Contains("SettingsFile")).First().Split("=")[1];
        var builder = new ConfigurationBuilder()
            .AddJsonFile(settingsFile, optional: false, reloadOnChange: true);
        IConfiguration config = builder.Build();
        Console.WriteLine($"SettingsFile: {settingsFile}");
        Console.WriteLine($"AppName value: {config.GetValue<string>("AppName")}");
        Console.ReadLine();
        Console.WriteLine("█SecondaryApp Exited");
    }
}

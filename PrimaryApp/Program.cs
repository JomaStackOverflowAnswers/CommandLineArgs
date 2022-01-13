using System.Diagnostics;

public class Program
{
    public async static Task Main(string[] args)
    {
        Console.WriteLine("██ PrimaryApp Started");
        var secondaryAppExeFilename = Path.GetFullPath("SecondaryApp/SecondaryApp.exe");
        var settingsFilename = Path.GetFullPath("appsettings.json"); // var settingsFilename = Path.GetFullPath("C:\appsettings.json");
        ProcessStartInfo info = new ProcessStartInfo();
        info.FileName = secondaryAppExeFilename;
        info.Arguments = $"--SettingsFile={settingsFilename}";
        info.WindowStyle = ProcessWindowStyle.Normal;
        Process process = new Process();
        process.StartInfo = info;
        process.Start();
        await process.WaitForExitAsync();
        Console.ReadLine();
        Console.WriteLine("█ PrimaryApp Exited");
    }
}

namespace Tools;

public static class LogManager
{
    private const string Path = "Log";

    public static string PathLog()
    {
        return $@"{Directory.GetParent(Directory.GetCurrentDirectory()).FullName}/bin/{Path}";
    }
    public static string CurrentPathFolder()
    {
        return PathLog() + "//" + DateTime.Now.ToString("MM-yyyy");
    }
    public static string CurrentPathFile()
    {
        return $@"{CurrentPathFolder()}/{DateTime.Now.Day}.log";
    }
    public static void WriteToLog(string project, string func, string message)
    {
        if (!Directory.Exists(CurrentPathFolder()))
        {
            Directory.CreateDirectory(CurrentPathFolder());
        }
        if(!File.Exists(CurrentPathFile())) 
        {
            File.Create(CurrentPathFile()).Close();             
        }
        using(StreamWriter writer = new StreamWriter(CurrentPathFile(), true))
        {
            writer.WriteLine($"{DateTime.Now}\t{project}.{func}:\t{message}\n");
        }
    }

    public static void DeleteLog()
    {
        DirectoryInfo dir = new DirectoryInfo(PathLog());
        DateTime date = DateTime.Now.AddMonths(-2);
        foreach (DirectoryInfo d in dir.GetDirectories()) 
        {
            if(DateTime.Parse(d.Name) < date)
                d.Delete(true);
        }
    }


}

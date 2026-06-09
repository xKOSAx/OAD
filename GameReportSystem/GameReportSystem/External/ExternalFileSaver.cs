namespace GameReportSystem.External;

public class ExternalFileSaver
{
    public void SaveToFile(string content)
    {
        File.WriteAllText("report.txt", content);
    }
}
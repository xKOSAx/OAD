using GameReportSystem.External;

namespace GameReportSystem.Adapters;

public class FileSaverAdapter : IReportSaver
{
    private readonly ExternalFileSaver _fileSaver;

    public FileSaverAdapter(ExternalFileSaver fileSaver)
    {
        _fileSaver = fileSaver;
    }

    public void Save(string content)
    {
        _fileSaver.SaveToFile(content);
    }
}
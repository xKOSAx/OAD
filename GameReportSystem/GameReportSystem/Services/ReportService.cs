using GameReportSystem.Adapters;
using GameReportSystem.Models;
using GameReportSystem.Strategies;

namespace GameReportSystem.Services;

public class ReportService
{
    private readonly IReportStrategy _strategy;
    private readonly IReportSaver _reportSaver;

    public ReportService(
        IReportStrategy strategy,
        IReportSaver reportSaver)
    {
        _strategy = strategy;
        _reportSaver = reportSaver;
    }

    public void GenerateAndSave(Player player)
    {
        string report = _strategy.GenerateReport(player);

        Console.WriteLine(report);

        _reportSaver.Save(report);
    }
}
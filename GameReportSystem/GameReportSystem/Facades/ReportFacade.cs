using GameReportSystem.Adapters;
using GameReportSystem.Enums;
using GameReportSystem.External;
using GameReportSystem.Factory;
using GameReportSystem.Models;
using GameReportSystem.Services;

namespace GameReportSystem.Facades;

public class ReportFacade
{
    public void GenerateAndSave(
        Player player,
        ReportType reportType)
    {
        var factory = new ReportStrategyFactory();

        var strategy = factory.CreateStrategy(reportType);

        var externalSaver = new ExternalFileSaver();

        var adapter = new FileSaverAdapter(externalSaver);

        var service = new ReportService(
            strategy,
            adapter);

        service.GenerateAndSave(player);
    }
}
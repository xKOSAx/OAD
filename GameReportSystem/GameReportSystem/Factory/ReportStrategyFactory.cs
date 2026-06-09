using GameReportSystem.Enums;
using GameReportSystem.Strategies;

namespace GameReportSystem.Factory;

public class ReportStrategyFactory
{
    public IReportStrategy CreateStrategy(ReportType type)
    {
        return type switch
        {
            ReportType.Text => new TextReportStrategy(),
            ReportType.Json => new JsonReportStrategy(),
            ReportType.Csv => new CsvReportStrategy(),
            _ => throw new ArgumentException("Nieznany typ raportu")
        };
    }
}
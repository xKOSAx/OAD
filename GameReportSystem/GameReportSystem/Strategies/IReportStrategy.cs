using GameReportSystem.Models;

namespace GameReportSystem.Strategies;

public interface IReportStrategy
{
    string GenerateReport(Player player);
}
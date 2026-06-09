using System.Text.Json;
using GameReportSystem.Models;

namespace GameReportSystem.Strategies;

public class JsonReportStrategy : IReportStrategy
{
    public string GenerateReport(Player player)
    {
        return JsonSerializer.Serialize(player,
            new JsonSerializerOptions
            {
                WriteIndented = true
            });
    }
}
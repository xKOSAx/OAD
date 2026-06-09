using GameReportSystem.Models;

namespace GameReportSystem.Strategies;

public class CsvReportStrategy : IReportStrategy
{
    public string GenerateReport(Player player)
    {
        return
$"Name,Level,Class,Gold,Achievements\n{player.Name},{player.Level},{player.CharacterClass},{player.Gold},{player.AchievementsCount}";
    }
}
using GameReportSystem.Models;

namespace GameReportSystem.Strategies;

public class TextReportStrategy : IReportStrategy
{
    public string GenerateReport(Player player)
    {
        return
$@"Gracz: {player.Name}
Poziom: {player.Level}
Klasa: {player.CharacterClass}
Złoto: {player.Gold}
Osiągnięcia: {player.AchievementsCount}";
    }
}
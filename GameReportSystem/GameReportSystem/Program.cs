using GameReportSystem.Enums;
using GameReportSystem.Facades;
using GameReportSystem.Models;

var player = new Player
{
    Name = "Jan",
    Level = 12,
    CharacterClass = "Mag",
    Gold = 1500,
    AchievementsCount = 4
};

var facade = new ReportFacade();

facade.GenerateAndSave(player, ReportType.Json);
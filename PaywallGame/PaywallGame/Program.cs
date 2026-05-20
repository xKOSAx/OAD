using PaywallGame.Enums;
using PaywallGame.Factory;
using PaywallGame.Models;
using PaywallGame.Services;

namespace PaywallGame;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player
        {
            Name = "Jan",
            Level = 12,
            IsPremium = false,
            HasDlc = true
        };

        var freeStrategy =
            AccessStrategyFactory.CreateStrategy(AccessType.Free);

        var freeService =
            new PaywallService(freeStrategy);

        freeService.CheckAccess(player);

        var premiumStrategy =
            AccessStrategyFactory.CreateStrategy(AccessType.Premium);

        var premiumService =
            new PaywallService(premiumStrategy);

        premiumService.CheckAccess(player);

        var levelStrategy =
            AccessStrategyFactory.CreateStrategy(AccessType.Level, 10);

        var levelService =
            new PaywallService(levelStrategy);

        levelService.CheckAccess(player);

        var dlcStrategy =
            AccessStrategyFactory.CreateStrategy(AccessType.Dlc);

        var dlcService =
            new PaywallService(dlcStrategy);

        dlcService.CheckAccess(player);
    }
}
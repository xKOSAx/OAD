using PaywallGame.Models;
using PaywallGame.Strategies;
using System;

namespace PaywallGame.Services;

public class PaywallService
{
    private IAccessStrategy _strategy;

    // Dependency Injection
    public PaywallService(IAccessStrategy strategy)
    {
        _strategy = strategy;
    }

    public void CheckAccess(Player player)
    {
        Console.WriteLine(_strategy.GetInfo());

        if (_strategy.CanAccess(player))
        {
            Console.WriteLine($"{player.Name} ma dostęp.");
        }
        else
        {
            Console.WriteLine($"{player.Name} nie ma dostępu.");
        }

        Console.WriteLine();
    }
}
using PaywallGame.Enums;
using PaywallGame.Strategies;
using System;

namespace PaywallGame.Factory;

public static class AccessStrategyFactory
{
    public static IAccessStrategy CreateStrategy(
        AccessType type,
        int level = 0)
    {
        switch (type)
        {
            case AccessType.Free:
                return new FreeAccessStrategy();

            case AccessType.Premium:
                return new PremiumAccessStrategy();

            case AccessType.Level:
                return new LevelAccessStrategy(level);

            case AccessType.Dlc:
                return new DlcAccessStrategy();

            default:
                throw new Exception("Nieznany typ.");
        }
    }
}
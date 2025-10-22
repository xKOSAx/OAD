using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Knight : Entity.Character
{
    public Knight(string name) : base(name, CharacterClass.Knight)
    {
        Health = 220;
        Strength = 7;
        Intelligence = 10;
        Agility = 4;
        Sigma = 16;
        Alpha = 2;
    }
}
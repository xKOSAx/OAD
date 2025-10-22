using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Giant : Entity.Character
{
    public Giant(string name) : base(name, CharacterClass.Giant)
    {
        Health = 300;
        Strength = 10;
        Intelligence = 3;
        Agility = 2;
        Sigma = 4;
        Alpha = 14;
    }
}
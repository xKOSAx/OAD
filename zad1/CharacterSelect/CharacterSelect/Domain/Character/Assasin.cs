using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Assasin : Entity.Character
{
    public Assasin(string name) : base(name, CharacterClass.Assasin)
    {
        Health = 100;
        Strength = 7;
        Intelligence = 18;
        Agility = 8;
    }
}
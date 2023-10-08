namespace ExercismCSharp;

public abstract class Character
{
    public string CharacterType { get; set; }

    protected Character(string characterType) => CharacterType = characterType;

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => false;

    public override string ToString() => $"Character is a {CharacterType}";
}

public class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target) => target.Vulnerable() ? 10 : 6;
}

public class Wizard : Character
{
    private bool spellPrepared;

    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target) => spellPrepared ? 12 : 3;

    public void PrepareSpell() => spellPrepared = true;

    public override bool Vulnerable() => !spellPrepared;
}
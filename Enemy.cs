namespace Unicorn;


public class Enemy
{
  public double Aggressiveness { get; private set; } = 0.85;
  public int GoldReward { get; private set; }
  public int ExperienceReward { get; private set; }

  public bool IsRooted { get; set; } = false;
  public Enemy(string name, int health, Weapon weapon, int xpReward = 25, int goldReward = 10, double aggressiveness = 0.85) : base(name, health, weapon)
  {
    ExperienceReward = xpReward;
    GoldReward = goldReward;
    Aggressiveness = aggressiveness;
  }
  public override void Attack(Character target)
  {
    if (Weapon == null)
    {
      Console.WriteLine("{Name} tries to attack, but has no weapon!");
      return;
    }
    int damage = Weapon.CalculateDamage(RandomProvider.Rng);
    Console.WriteLine($"{Name} strikes {target.Name} with {Weapon.Name}, dealing {damage} damage!");
    target.TakeDamage(damage);

    if (Weapon.Durability == 0)
    {
      Console.WriteLine($"{Name}'s {Weapon.Name} is broken!");
    }
  }
  public void TakeTurn(Character player)
  {
    if (!IsAlive) return;
    ProcessEffects();
    if (!IsAlive) return;
    if (IsCrowdControlled)
    {
      Console.WriteLine($"{Name} is crowd-controlled and cannot act this turn.");
      return;
    }
    double roll = RandomProvider.Rng.NextDouble();
    if (roll < Aggressiveness)
    {
      Attack(player);
    }
    else
    {
      Defend();
    }
  }
  private void Defend()
  {
    Console.WriteLine($"{Name} braces and defends (will take reduced damage next attack).");
    AddStatusEffect(new StatusEffect("Defend, 0, 1, isDamage: false, isBuff: true"));

  }
  protected override void OnDeath()
  {
    base.OnDeath();
  }
}

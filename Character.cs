namespace Unicorn;

public abstract class Character
{
  public string Name { get; protected set; }
  public int Health { get; protected set; }
  public int MaxHealth { get; protected set; }
  public Weapon weapon { get; protected set; }

  public bool IsAlive => Health > 0;

  private List<StatusEffect> activeEffects = new List<StatusEffect>();
  public IsReadOnlyList<StatusEffect> ActiveEffects => activeEffects.AsReadOnly();
  public bool IsCrowdControlled { get; set; } = false;
  public int CrowdControlDuration { get; set; } = 0;
  protected Character(string name, int health, Weapon weapon)
  {
    Name = name ?? "Nameless";
    MaxHealth = Math.Max(1, health);
    Health = MaxHealth;
    Weapon = weapon;
  }
  public abstract void Attack(Character target);
  public virtual void TakeDamage(int damage)
  {
    if (!IsAlive) return;
    if (damage <= 0) return;
    if (IsCrowdControlled)
    {

    }
    Health -= damage;
    if (Health < 0) Health = 0;
    Console.WriteLine($"{Name} takes {damage} damage. (HP: {Health}/{MaxHealth})");

  }
  protected virtual void OnDeath()
  {
    Console.WriteLine($"{Name} has died!");
  }
  public void AddStatusEffect(StatusEffect effect)
  {
    if (effect == null) return;
    activeEffects.Add(effect);
  }
  public void ProcessEffects()
  {
    if (IsCrowdControlled)
    {
      CrowdControlDuration--;
      if (CrowdControlDuration <= 0)
      {
        IsCrowdControlled = false;
        CrowdControlDuration = 0;
        Console.WriteLine($"{Name} is no longer crowd-controlled.");
      }
    }
    for (int i = activeEffects.Count - 1; i >= 0; i--)
    {
      var eff = activeEffects[i];
      eff.Tick(this);
      if (eff.IsExiperd)
        activeEffects.RemoveAt(i);
    }
  }
}
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
}

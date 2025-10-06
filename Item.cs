namespace App;

class Item
{
  public string? Name;
  public string? Description;
  public int Amount;

  public Item(string? name, string? description, int amount)
  {
    Name = name;
    Description = description;
    Amount = amount;
  }
}

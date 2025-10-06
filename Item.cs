namespace App;

class Item
{
  public string? Name;
  public string? Description;
  public int Amount;

  public string owner;

  public Item(string? name, string? description, int amount,string owner)
  {
    Name = name;
    Description = description;
    Amount = amount;
  }
}

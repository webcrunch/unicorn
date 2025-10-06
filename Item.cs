namespace App;

class Item
{
  public string? Name;
  public string? Description;
  public int Amount;

  public string Owner;

  public Item(string? name, string? description, int amount, string owner)
  {
    Name = name;
    Description = description;
    Amount = amount;
    Owner = owner;
  }

  public void Info()
  {
    Console.WriteLine($"The item's name is: {Name}, \ndescription: {Description}, \namount: {Amount} \nand owner is: {Owner}. ");
  }
}

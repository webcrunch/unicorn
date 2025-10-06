namespace App;

class Product
{
    public string? Name;
    public string? Description;
    public int Amount;

    public string Productowner;
   public Product(string? name, string? description, int amount)
    {
        Name = name;
        Description = description;
        Amount = amount;
    }
}
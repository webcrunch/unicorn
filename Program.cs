
using App;

Weapon weapon = new Weapon("sharp sword", 75);
Unicorn unicorn = new Unicorn("Glitterhorn", 100);

string myEnemy = "Old Dragon";
int enemyHealth = 35;

bool running = true;

while (running)
{
    Console.Clear();
    Console.WriteLine($"Eenemy: {myEnemy} | Health: {enemyHealth}");
    Console.WriteLine($"You: {unicorn.Name} | WEAPON: {unicorn.weapon}");
}

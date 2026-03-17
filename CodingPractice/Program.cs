using System;
using System.Collections.Generic;
using System.Threading.Channels;
/*
// README.md를 읽고 코드를 작성하세요.
//1.
string s1 = "Hello";
string s2 = "Hello";
string s3 = new string("Hello".ToCharArray());

Console.WriteLine(s1 == s2);
Console.WriteLine(s1 == s3);

Console.WriteLine(object.ReferenceEquals(s1,s2));
Console.WriteLine(object.ReferenceEquals(s1,s3));

//2.
Player p1 = new Player("hero", 10);
Player p2 = new Player("hero", 10);
Player p3 = p1;

Console.WriteLine($"p1 == p2: {p1 ==p2}");
Console.WriteLine($"p1 == p3: {p1 ==p3}");
Console.WriteLine($"p1.Equals(p2): {p1.Equals(p2)}");
Console.WriteLine($"p1.Equals(p3): {p1.Equals(p3)}");
class Player
{
    public string Name;
    public int Level;

    public Player(string name, int level)
    {
        Name = name; Level = level; 
    }
}

//3.
Position pos1 = new Position(10, 20);
Position pos2 = new Position(10, 20);
Position pos3 = new Position(30, 40);

Console.WriteLine($"pos1.Equals(pos2): {pos1.Equals(pos2)}");
Console.WriteLine($"pos1.Equals(pos3): {pos1.Equals(pos3)}");

struct Position
{
    public int X;
    public int Y;

    public Position(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }
}

//4.
Item item1 = new Item("Sword", 1);
Item item2 = new Item("Sword", 1);
Item item3 = new Item("shield", 2);

Console.WriteLine($"item1.Equals(item2): {item1.Equals(item2)}");
Console.WriteLine($"item1.Equals(item3): {item1.Equals(item3)}");

HashSet<Item> inventory = new HashSet<Item>();
inventory.Add(item1);
Console.WriteLine($"inventory.Contains(item2): {inventory.Contains(item2)}");


class Item : IEquatable<Item>
{
    public string Name;
    public int Id;

    public Item(string name, int id)
    {
        Name = name; Id = id; 
    }

    public bool Equals(Item other)
    {
        if (other == null)
        {
            return false;
        }
        return Id == other.Id && Name == other.Name;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as Item);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Id);
    }
}

//5.
BadItem b1 = new BadItem("Potion");
BadItem b2 = new BadItem("Potion");

Console.WriteLine($"b1.Equals(b2):{b1.Equals(b2)}");

Dictionary<BadItem, int> stock = new Dictionary<BadItem, int>();
stock[b1] = 10;
Console.WriteLine($"stock.ContainsKey(b2):{stock.ContainsKey(b2)}");
class BadItem
{
    public string Name;
    public BadItem (string name)
    {
        Name = name; 
    }
    public override bool Equals(object obj)
    {
        BadItem other = obj as BadItem;
        if (other == null)
        {
            return false;
        }
        return Name == other.Name;
    }
    
}
**/
//6.
List<Monster> monsters = new List<Monster>
{
    new Monster("Goblin", 30),
    new Monster("Dragon", 100),
    new Monster("Slime", 10),
    new Monster("Orc", 50)
};

Console.WriteLine("정렬 전:");
foreach (var item in monsters)
{
    Console.WriteLine($"   {item}");
}

monsters.Sort();
Console.WriteLine("정렬 후:");
foreach (var item in monsters)
{
    Console.WriteLine($"   {item}");
}

class Monster : IComparable<Monster>
{
    public string Name;
    public int Power;
    public Monster(string name, int power)
    {
        Name = name;
        Power = power;
    }
    public int CompareTo(Monster other)
    {
        if (other == null)
        {
            return 1;
        }
        return Power.CompareTo(other.Power);
    }

    public override string ToString()
    {
        return $"{Name}(전투력: {Power})";
    }
}



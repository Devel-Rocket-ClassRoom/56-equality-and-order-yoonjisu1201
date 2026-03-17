using System;
using System.Collections.Generic;
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
*/
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


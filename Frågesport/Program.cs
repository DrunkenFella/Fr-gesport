// string name = "Alex";

// bool isAlive = name == "Alex";

// Console.WriteLine(isAlive);

// Console.ReadLine();

// if (true)
// {
//     Console.WriteLine("Yes");
// }

// / math
// int potion = 50;

// int hitpoints = 200 + potion;

// hitpoints += potion;

// / +1 
// hitpoints++;

// Console.WriteLine(hitpoints);

// /räknesätten fungerar som vanligt. int har inte decimaltal 

using System;
using System.Threading;

Console.CursorVisible = false;

static void Close()
{
    Console.ReadKey();
    Environment.Exit(0);
}

int score = 0;

Console.WriteLine("Welcome to the guessing game.");
Console.WriteLine("Your name will be Chad Thundercock if you win.");
Console.ReadKey(true);
// start 
Console.WriteLine("You will be answering 1,2 or 3.");

Console.ReadKey(true);
Console.WriteLine("Question 1, what is the meaning with life?");
Console.WriteLine("1: Having children, 2: Having fun, 3: 42");
if (Console.ReadKey().KeyChar == '3')
{
    Console.WriteLine($"\nWell done!");
    score++;
}
else
{
    Console.WriteLine($"\nDamn you suck!");
}
Thread.Sleep(1000);
Console.Clear();
Console.WriteLine("Question 2, How many bones are there in the cat body?");
Console.WriteLine("1: 206, 2:230, 3:250 ");
if (Console.ReadKey().KeyChar == '2')
{
    Console.WriteLine($"\nWell done!");
    score++;
}
else
{
    Console.WriteLine($"\nDamn you suck!");
}
Thread.Sleep(1000);
Console.Clear();
Console.WriteLine("Question 3, How many games are on steam?");
Console.WriteLine("1: 50,361, 2: 123,517, 3: 70,682");
if (Console.ReadKey().KeyChar == '1')
{
    Console.WriteLine($"\nWell done!");
    score++;
}
else
{
    Console.WriteLine($"\nDamn you suck!");
}
Thread.Sleep(1000);
Console.Clear();

if (score == 3)
{
    Console.WriteLine("Here by I name you Chad Thundercock.");
}
else if (score == 2)
{
    Console.WriteLine("You are almost Chad Thundercock. But go away peasant.");
}
else
{
    Console.WriteLine("You are no Chad Thundercock go away peasant.");
}
Console.ReadKey(true);
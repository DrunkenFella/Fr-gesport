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

static void Close()
{
    Console.ReadKey();
    Environment.Exit(0);
}

int score = 0;

Console.WriteLine("Welcome to the guessing game.");
Console.WriteLine("Your name will be Chad Thundercock if you win.");
Console.ReadLine();
// start 
Console.WriteLine("You will be answering with 1,2 and 3.");
Console.ReadLine();
Console.WriteLine("Question 1, what is the meaning with life?");
Console.WriteLine("1: Having children, 2: Having fun, 3: 42");


if (score == 3)
{
    Console.WriteLine("Here by I name you Chad Thundercock.");
    Close();
}
else if (score == 2)
{
    Console.WriteLine("You are almost Chad Thundercock. But go away peasant.");
    Close();
}
else
{
    Console.WriteLine("You are no Chad Thundercock go away peasant.");
    Close();
}
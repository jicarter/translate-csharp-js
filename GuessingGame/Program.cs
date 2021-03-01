using System;

Console.WriteLine("You have 4 attempts. Guess the secret number...");
string input = Console.ReadLine();
string SecretNumber = "42";
Console.WriteLine($"Your guess {input}");

if (input == SecretNumber)
{
    Console.WriteLine("CORRECT!");
    Environment.Exit(0);
}
else
{
Console.WriteLine("FAILED!");
}

Console.WriteLine("TRY AGAIN...");
Console.WriteLine("You have 3 attempts left. Guess the secret number...");
string input2 = Console.ReadLine();
Console.WriteLine($"Your guess {input2}");

if (input2 == SecretNumber)
{
    Console.WriteLine("CORRECT!");
    Environment.Exit(0);
}
else
{
Console.WriteLine("FAILED!");
}

Console.WriteLine("TRY AGAIN...");
Console.WriteLine("You have 2 attempts left. Guess the secret number...");
string input3 = Console.ReadLine();
Console.WriteLine($"Your guess {input3}");

if (input3 == SecretNumber)
{
    Console.WriteLine("CORRECT!");
    Environment.Exit(0);
}
else
{
Console.WriteLine("FAILED!");
}

Console.WriteLine("TRY AGAIN...");
Console.WriteLine("You have 1 attempt left. Guess the secret number...");
string input4 = Console.ReadLine();
Console.WriteLine($"Your guess {input4}");

if (input4 == SecretNumber)
{
    Console.WriteLine("CORRECT!");
    Environment.Exit(0);
}
else
{
Console.WriteLine("YOU LOSE!");
}
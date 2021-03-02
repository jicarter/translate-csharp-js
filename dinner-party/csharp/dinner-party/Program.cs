using System;
using System.Linq;
using System.Collections.Generic;

Console.WriteLine("Dinner-Party");
Console.WriteLine("============");
List<guest> guests = GetGuests();

foreach (guest myGuest in guests)
{
    if (myGuest.occupation == myGuest.occupation)
    {
        Console.WriteLine("Table 1");
        Console.WriteLine($"{myGuest.name} {myGuest.occupation}");
    }
    else
    {
        Console.WriteLine("Table 2");
        Console.WriteLine($"{myGuest.name}");
    }
}

List<guest> GetGuests()
{
    List<guest> guests = new List<guest> {
    new guest
    {
        name = "Marilyn Monroe",
        occupation = "entertainer",
        bio = "(1926 - 1962) American actress, singer, model"
    },
    new guest
    {
        name = "Abraham Lincoln",
        occupation = "politician",
        bio = "(1809 - 1865) US President during American civil war"
    },
    new guest
    {
        name = "Martin Luther King",
        occupation = "activist",
        bio = "(1929 - 1968)  American civil rights campaigner"
    },
    new guest
    {
        name = "Rosa Parks",
        occupation = "activist",
        bio = "(1913 - 2005)  American civil rights activist"
    },
    new guest
    {
        name = "Peter Sellers",
        occupation = "entertainer",
        bio = "(1925 - 1980) British actor and comedian"
    },
    new guest
    {
        name = "Alan Turing",
        occupation = "computer scientist",
        bio = "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
    },
    new guest
    {
        name = "Admiral Grace Hopper",
        occupation = "computer scientist",
        bio = "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
    },
    new guest
    {
        name = "Indira Gandhi",
        occupation = "politician",
        bio = "(1917 - 1984) Prime Minister of India 1966 - 1977",
    }
};
    return guests;
}


public class guest
{
    public string name { get; set; }
    public string occupation { get; set; }
    public string bio { get; set; }
}
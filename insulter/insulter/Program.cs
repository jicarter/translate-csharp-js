using System;

for (int i = 0; i < 7; i++)
{
    Generate insult = Insult();

    string message = $"{insult}";

    Console.WriteLine(message);
}




Generate Insult()
{
    int insultValue = new Random().Next(1, 7);
    Generate insult = new Generate(insultValue);
    return insult;
}

public class Generate
{
    public int Value {get; set;}

    public Generate(int value)
    {
        this.Value = value;
    }

    public override string ToString()
    {
        string insultString = "Unknown";

        switch (this.Value)
        {
            case 1:
                insultString = "You look like what morning breath smells like.";
                break;
            case 2:
                insultString = "If you tried to give me cpr I would probably throw myself back under water";
                break;
            case 3:
                insultString = "I am not a fan of you";
                break;
            case 4:
                insultString =  "You think you're so special...and you are. The fact of your existence is nearly impossible to believe";
                break;
            case 5:
                insultString = "I'd rather walk than be on the same plane as you";
                break;
            case 6:
                insultString = "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy";
                break;
            case 7:
                insultString = "Do you have to be so...like that?";
                break;
        }

        return insultString;
    }
}
using System;


int char1HP = 100;
int char2HP = 100;


Random generator = new Random();


Console.WriteLine("Vad heter du?");
string char1Name = Console.ReadLine();


while (char1HP > 0 && char2HP > 0)
{
    Console.WriteLine("Rundan har startat");
    Console.WriteLine("//--------------------------//\n");
    int char1Damage = generator.Next(40);
    char2HP -= char1Damage;
    char2HP = Math.Max(0, char2HP);
    Console.WriteLine($"{char1Name} gör {char1Damage} damage \n");

    int char2Damage = generator.Next(40);
    char1HP -= char2Damage;
    char1HP = Math.Max(0, char1HP);
    Console.WriteLine($"Potatoman gör {char2Damage} damage \n");

    Console.WriteLine($"{char1Name}: {char1HP}hp // Potatoman: {char2HP}hp\n");


    Console.WriteLine("//--------------------------//\n");
    Console.WriteLine("Tryck på en tangent för att fortsätta spela");
    Console.ReadKey();
}


Console.WriteLine("//--------------------------//\n");
Console.ReadLine();


if (char1HP == 0 && char2HP == 0)
{
    Console.WriteLine($"Både {char1Name} och Potatoman dog");
}


else if (char1HP == 0)
{
    Console.WriteLine("damn, fett sämst");
    Console.WriteLine("...");
    Console.WriteLine("stel tystnad...");

}
else
{
    Console.WriteLine($"{char1Name} vann! Bra jobbat i guess");

}


string ans = Console.ReadLine();

Console.WriteLine("Skriv på 'Exit' för att avsluta spelet.");

if (ans == "Exit")
{
    System.Environment.Exit(0);
}

/* INTE FÄRDIGT */
Console.WriteLine("Tryck på 'ENTER' för att spela igen");

Console.ReadLine();



    int points = 0;
rules();main();
void main()
{
    
    int rnd1 = rand();
    int rnd2 = rand();
    Console.WriteLine($"Dine Poeng:{points}");
    Console.WriteLine($"{rnd1} _ {rnd2}");
    string answer = Console.ReadLine();
    if (rnd1 == rnd2)
    {
        if (answer == "=")
        {
            points++;
            Console.WriteLine("Correct!");
        }
        else
        {
            points--;
            Console.WriteLine("Wrong!");
        }
    }
    else if (rnd1 < rnd2)
    {
        if (answer == "<")
        {
            points++;
            Console.WriteLine("Correct!");
        }
        else
        {
            points--;
            Console.WriteLine("Wrong!");
        }
    }
    else if (rnd1 > rnd2)
    {
        if (answer == ">")
        {
            points++;
            Console.WriteLine("Correct!");
        }
        else
        {
            points--;
            Console.WriteLine("Wrong!");
        }
    }
    main();
}

void rules()
{
    Console.WriteLine("Hvilket av tallene er størst?");
    Console.WriteLine("Regler:");
    Console.WriteLine("Bruk < , > eller = for å si hvilket tall som er størst");
    Console.WriteLine("Ved riktig svar, får du 1 poeng.");
    Console.WriteLine("Ved feil svar, mister du 1 poeng.");
}

int rand()
{
    var rnd = new Random();
    var rndNumber = rnd.Next(0, 20);
    return rndNumber;
}



int r = 0;
while (true)
{
    try
    {
        Console.WriteLine("How many sides do your dice have?");
        r = int.Parse(Console.ReadLine());
        if(r <= 3)
        {
            throw new Exception("Input too low.");
        }
        else
        {
            //valid
            break;
        }
    }
    catch (Exception i)
    {
        Console.WriteLine(i.Message);
    }
}
/// ^^^^^^^^loop to get number 
bool runProgram = true;
while (runProgram)
{
    int first = RandomRoll(r);
    int second = RandomRoll(r);

    Console.WriteLine(String.Format("{0,20}", "Roll 1"));
    Console.WriteLine($"You rolled a {first} and a {second} your total is {first + second}!");

    if (r == 6)
    {
        if (first == 1 && second == 1)
        {
            Console.WriteLine("Snake Eyes!!!");
            Console.WriteLine("Craps!");
        }
        else if (first + second == 3)
        {
            Console.WriteLine("Ace Deuce!!!");
            Console.WriteLine("Craps!");
        }
        else if (first == 6 && second == 6)
        {
            Console.WriteLine("Box Cars!!!");
            Console.WriteLine("Craps!");
        }
        else if (first + second == 7 )
        {
            Console.WriteLine("You Win!!!");
        }
        else if (first + second == 11)
        {
            Console.WriteLine("You Win!!!!");
        }
        
    }
    int x = 0;
    while (x == 0)
    {
    Console.WriteLine("Would you like to roll again? y/n");
    string yesNo = Console.ReadLine();

        if (yesNo == "n")
        {
            runProgram = false;
            break;
        }
        else if (yesNo == "y")
        {
            runProgram = true;
            x++;
        }
        else
        {
            Console.WriteLine("invalid input");

        }
    }
}
Console.WriteLine("Thank you for playing, come back anytime ;)");


//-----------------------------  methods   ----------------------------
static int RandomRoll(int sides)
{
    Random dice = new Random();
    int x = 0;
    if (x == 0)
    {
    int roll = dice.Next(1, sides + 1);
    return roll;
    }
    else
    {
    return 0;
    }
}
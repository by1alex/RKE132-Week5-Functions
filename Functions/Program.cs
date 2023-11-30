//Console.WriteLine("HelloWorld");

Console.WriteLine("Are you coming or leaving? (in/out):");
string userChoice = Console.ReadLine();

if (userChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodbye();
}


static void PrintHello()
{
    Console.WriteLine("Hello!");
}

static void PrintGoodbye()
{
    Console.WriteLine("See you later, aligator!");
}
//Task 1
using Microsoft.VisualBasic;
using System.Diagnostics;

Main();

static void Main() 
{
    string message = "";
    do
    {
        PrintMenu();
        int option = InputOption();
        message = GetMessage(option);
        Console.WriteLine(message);
    }
    while (message != "Goodbye");
}

static void PrintMenu()
{
    Console.WriteLine("Please enter a valid option from below: ");
    Console.WriteLine("1. Hello in French?");
    Console.WriteLine("2. Hello in Spanish?");
    Console.WriteLine("3. Hello in German?");
    Console.WriteLine("4. Hello in Itaian?");
    Console.WriteLine("0. Exit application");
}

//Task 2
static int InputOption()
{
    int option;
    try
    {
        option = Convert.ToInt32(Console.ReadLine());

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
        option = 0;
    }
    return option;
}

//Task 3
static string GetMessage(int language)
{
    //This is a local variable and is only used within this method.
    string message = "";
    switch (language)
    {
        case 0:
            message = "Goodbye";
            break;
        case 1:
            message = "Bonjour";
            break;
        case 2:
            message = "Hola";
            break;
        case 3:
            message = "Hallo";
            break;
        case 4:
            message = "Ciao";
            break;
        default:
            message = "Please enter a valid option from the menu";
            break;
    }
    return message;
}
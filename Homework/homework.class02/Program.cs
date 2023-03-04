// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//exercise 7

Console.Write("Enter a number from 1 to 3: ");
string input = Console.ReadLine();
int number;

if (int.TryParse(input, out number))
{
    switch (number)
    {
        case 1:
            Console.WriteLine("You got a new car!");
            break;
        case 2:
            Console.WriteLine("You got a new plane!");
            break;
        case 3:
            Console.WriteLine("You got a new bike!");
            break;
        default:
            Console.WriteLine("Error: Invalid input. Please enter a number from 1 to 3.");
            break;
    }
}
else
{
    Console.WriteLine("Error: Invalid input. Please enter a number from 1 to 3.");
}

Console.ReadLine();
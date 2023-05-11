
// Create a Console Application that asks user for their name.
// Welcome me (Tim) as professor and anyone else as student.
// Do this until the user types "exit"

string response;

do
{
    //ask user for their name
    Console.Write("What is your name: ");
    response = Console.ReadLine();

    if (response.ToLower() != "exit")
    {
        if (response.ToLower() == "tim")
        {
            Console.WriteLine("Welcome Professor.");
        }
        else
        {
            Console.WriteLine("Welcome Student.");
        }
    }

} while (response.ToLower() != "exit");
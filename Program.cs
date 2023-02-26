// BREIF: 
// Create a basic console app using if and else statements


Console.Write("What is your first name: ");
string? firstName = Console.ReadLine();

if (firstName == "Josh")
{
    Console.WriteLine("Hello Mr. O'Connor");
}
else
{
    Console.WriteLine($"Hello {firstName}");
}

Console.WriteLine("End of program.");
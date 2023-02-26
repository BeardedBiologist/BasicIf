// BREIF: 
// Create a basic console app using if and else statements


Console.Write("What is your first name: ");
string? firstName = Console.ReadLine();
string? lastName;

if (firstName.ToLower() == "josh")
{
    Console.WriteLine("Hello Mr. O'Connor");
    lastName = "O'Connor";
}
else
{
    Console.WriteLine($"Hello {firstName}");
    lastName = "Smith";
}

Console.WriteLine("Last name: " + lastName);
Console.WriteLine("End of program.");
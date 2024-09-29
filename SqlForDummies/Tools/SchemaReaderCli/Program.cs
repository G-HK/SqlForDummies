using DatabaseInterpreter;

Console.WriteLine("Schema Reader V1");

Console.WriteLine("Select The Type Database connections");
foreach (var providerType in ProviderType)
{
    Console.WriteLine("{number}: {name}", providerType, nameof(providerType));
}

Console.WriteLine("Give The Connectionstring for the Database: ");
string? connectionString = Console.ReadLine();

if (connectionString == null)
{
    return;
}

// Read Database and create Schema and show it in console.


// Create Exit Key Command to close the application 
// and in the end also ask if he wanted to save the setting for in the futher. 

string? yesOrNo;

do
{
    Console.WriteLine("Do you Wanted to Save the settings?");
    Console.WriteLine("Yes Or No");
    yesOrNo = Console.ReadLine();

    // True or False
} while (yesOrNo is "Yes" or "yes" or "y" or "Y" or "No" or "no" or "n" or "N");


try
{
    // if yes ask for name for save file
    // no close the application by saying s
}
finally
{
    Console.WriteLine("Good morning,\r\nIn case if I Don't see you Good afternoon, Good Evening and Good Night.");
}
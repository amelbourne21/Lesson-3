// See https://aka.ms/new-console-template for more information
Console.WriteLine("This application only uses whole numbers");
Console.WriteLine("What is your initial deposit?: ");
var initialDepositInput = Console.ReadLine();

int initialDeposit;

if(int.TryParse(initialDepositInput, out initialDeposit))
{
 //input is valid   
}
else
{
    Console.WriteLine("Invalid input");
}

Console.WriteLine("What is your monthly interest rate? (As a percentage): ");
var monthlyInterestRateInput = Console.ReadLine();

int monthlyInterestRate;

if(int.TryParse(monthlyInterestRateInput, out monthlyInterestRate))
{
 //input is valid   
}
else
{
    Console.WriteLine("Invalid input");
}

Console.WriteLine("How many months would you like to save for?: ");
var monthsSavingInput = Console.ReadLine();

int monthsSaving;

if(int.TryParse(monthsSavingInput, out monthsSaving))
{
 //input is valid   
}
else
{
    Console.WriteLine("Invalid input");
}

var savings = initialDeposit * Math.Pow(1 + (monthlyInterestRate/100),monthsSaving);

Console.WriteLine($"Your savings are now ${savings}");

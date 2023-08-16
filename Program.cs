

using ClassesPractice;

Console.WriteLine("Making an Employee");
Console.WriteLine("------------------\n");

//Making a new object "bethany" of type Employee by invoking the Employee class. It also uses the constructor, pretty cool :)
Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);

//Displays bethanies details
bethany.DisplayEmployeeDetails();

//Bethany goes to work
for(int i = 1; i < 5; i++)
{
    bethany.PerformWork(i);
}

bethany.PerformWork(5);

//Calculates Bathenies wage
double receiveWageBethany = bethany.RecieveWage(true);
Console.WriteLine($"Wage was paid (message from program): {receiveWageBethany}");

//Changing the values of bethany
bethany.firstName = "John";
bethany.lastName = "WIlliam";

bethany.DisplayEmployeeDetails();

//New employee
Console.WriteLine("Making an Employee");
Console.WriteLine("------------------\n");

//New object, George
Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30);

//Georges details
george.DisplayEmployeeDetails();


//George goes to work
for (int i = 1; i < 5; i++)
{
    george.PerformWork(i);
}

george.PerformWork(5);

var receivedWageGeorge = george.RecieveWage(true);
using System.Runtime.InteropServices;

//input
while(true){
Console.WriteLine("Grade Evaluation");
Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();
Console.WriteLine("Enter the grades of the following: ");
Console.WriteLine("Data Structures: ");
int g1 = int.Parse(Console.ReadLine());
Console.WriteLine("PATHFIT: ");
int g2 = int.Parse(Console.ReadLine());
Console.WriteLine("Programming 3: ");
int g3 = int.Parse(Console.ReadLine());
Console.WriteLine("Operarating System: ");
int g4 = int.Parse(Console.ReadLine());
Console.WriteLine("Data Communication: ");
int g5 = int.Parse(Console.ReadLine());

//computation
int avg = (g1 +g2+g3+g4+g5)/5;

//Output
Console.WriteLine($"Name: {name}");
Console.WriteLine($"Data Structures: {g1}");
Console.WriteLine($"PATHFIT: {g2}");
Console.WriteLine($"Programming 3: {g3}");
Console.WriteLine($"Operarating System: {g4}");
Console.WriteLine($"Data Communication: {g5}");
Console.WriteLine($"Average Grade: {avg}");

//nested if-else
if(avg<=100)
{
    if(avg >= 97){
Console.WriteLine("Numerical Grade/Equivalent: 1.00");
}else if(avg >= 94)
    {
    Console.WriteLine("Numerical Grade/Equivalent: 1.25");
    }else if(avg >= 91)
    {
    Console.WriteLine("Numerical Grade/Equivalent: 1.50");
    }else if(avg >= 88)
    {
    Console.WriteLine("Numerical Grade/Equivalent: 1.75");
    }else if(avg >= 85)
    {
    Console.WriteLine("Numerical Grade/Equivalent: 2.00");
    }else if(avg >= 82)
    {
    Console.WriteLine("Numerical Grade/Equivalent: 2.25");
    }else if(avg >= 79)
    {
    Console.WriteLine("Numerical Grade/Equivalent: 2.50");
    } else if(avg >= 76)
    {
    Console.WriteLine("Numerical Grade/Equivalent: 2.75");
    }else if(avg == 75)
{
    Console.WriteLine("Numerical Grade/Equivalent: 3.00");
}else if(avg >= 65)
    {
    Console.WriteLine("Numerical Grade/Equivalent: 5.00");
    }else
{
    Console.WriteLine("Numerical Grade/Equivalent: Incomplete");
}
}
Console.WriteLine("Do you still want to evaluate your grade? (yes or no): ");
string yesno = Console.ReadLine().ToLower();
if(yesno == "no")
    {
        Console.WriteLine("Thank you for using Grade Evaluation!");
    break;
} else if(yesno == "yes")
{
        Console.WriteLine("Loading...");
    } else 
    {
        Console.WriteLine("Error, but I'll take that as a yes");
    }
    } 

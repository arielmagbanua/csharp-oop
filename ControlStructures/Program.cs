int weekNumber = 100;

switch (weekNumber) {
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    default:
        Console.WriteLine("Invalid");
        break;
}


double grade = 80.0;

if (grade >= 75.0)
{
    if (grade >= 90.0)
    {
        Console.WriteLine("Excellent!!!");
    }
    else if (grade >= 80.0 && grade < 90.0)
    {
        Console.WriteLine("Nice!!!");
    }
    else
    {
        Console.WriteLine("Passed!!!");
    }
}
else
{
    Console.WriteLine("Failed!!!");
}

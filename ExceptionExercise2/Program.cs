using ExceptionExercise2;

App app = new App();


while (true)
{


    try
    {
        Console.Write("Input a number: ");
        string consoleInput = Console.ReadLine();
        int num = Convert.ToInt32(consoleInput);

        app.Number(num);
        break;
    }
    catch (ArgumentException exception)
    {
        Console.WriteLine("Wrong input!");
    }
    catch (Exception exception)
    {
        Console.WriteLine("Please provide another input");
    }
}


Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Welcome to our Simple Calculator App");
Console.BackgroundColor = ConsoleColor.White;
Console.ResetColor();
Console.WriteLine("Choose An Option");
Console.WriteLine("Enter 1 to Multiply\nEnter 2 to Add\nEnter 3 to Subtract\nEnter 4 to Divide\nEnter 5 for Modulo");

bool userInput = int.TryParse(Console.ReadLine(), out int value);
if (userInput == false)
{
    Console.WriteLine("Input valid number!");
    Console.WriteLine("");
}
else if (value > 5 || value < 1)
{
    Console.WriteLine("Read the instruction");
}
else
{
    Console.WriteLine("WellDone");
}

try
{
    switch (value)
    {
        case 1:
            float input = Prompt("Enter Your First Number: ");
            float input2 = Prompt("Enter Your Second Number: ");
            float multiplyResult = Multiply(input, input2);
            Console.WriteLine("The result is {0}", multiplyResult);
            break;
        case 2:
            float add1 = Prompt("Enter Your First Number: ");
            float add12 = Prompt("Enter Your Second Number: ");
            float addResult = Add(add1, add12);
            Console.WriteLine("The result is {0}", addResult);
            break;
        case 3:
            float subtract1 = Prompt("Enter Your First Number: ");
            float subtract2 = Prompt("Enter Your Second Number: ");
            float subtractResult = Subtract(subtract1, subtract2);
            Console.WriteLine("The result is {0}", subtractResult);
            break;
        case 4:
            float numerator = Prompt("Enter Your Numerator: ");
            float denominator = Prompt("Enter your Denominator: ");
            float divideNums = Divide(numerator, denominator);
            Console.WriteLine("The result is {0}", divideNums);
            break;
        case 5:
            float modulo = Prompt("Enter Your First Number: ");
            float moduloSecondNum = Prompt("Enter your Second Number: ");
            float remainder = Modulo(modulo, moduloSecondNum);
            Console.WriteLine("The result is {0}", remainder);
            break;
        default:
            Console.WriteLine("Not Found");
            break;
    }
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Error: Cannot divide by zero.{ex.Message}");
}

float Multiply(float a, float b)
{
    return a * b;
}

float Add(float a, float b)
{
    return a + b;
}

float Subtract(float a, float b)
{
    return a - b;
}

float Divide(float a, float b)
{
    try
    {
        if (b == 0)
            throw new DivideByZeroException();
        return (float)a / b;  
    }
    catch (DivideByZeroException)
    {
        throw; 
    }
}

float Modulo(float a, float b)
{
    if (b == 0)
    {
        Console.WriteLine("Error: Modulo by zero.");
        return 0;
    }
    return a % b;
}

float Prompt(string text)
{
    float result;
    while (true)
    {
        try
        {
            Console.Write(text);
            if (float.TryParse(Console.ReadLine(), out result))
                return result;

            throw new FormatException("Invalid number format.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
//
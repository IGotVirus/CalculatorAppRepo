//Calculator from Nikita Homework

decimal numberOne;
decimal numberTwo;

Console.WriteLine("Hello, please choose the arithmetic operation type and press enter: ");
Console.WriteLine();
Console.WriteLine(" Press 1 for: \"-\"\n Press 2 for: \"+\"\n Press 3 for: \"*\"\n Press 4 for: \"/\"");
int userOperatorInput = Convert.ToInt32(Console.ReadLine());
Console.Clear();

Console.Write("Please enter the first number operand: ");
numberOne = Convert.ToDecimal(Console.ReadLine());
Console.Clear();

Console.Write("Please enter the second operand number: ");
numberTwo = Convert.ToDecimal(Console.ReadLine());
Console.Clear();

switch (userOperatorInput)
{
    case 1:
        Console.WriteLine($"Here is your operation result: {numberOne} {"-"} {numberTwo} {"="} {numberOne - numberTwo}");
        Console.WriteLine();
        Console.WriteLine("Thank you, press any key to exit the program.");
        Console.ReadKey();
        break;
    case 2:
        Console.WriteLine($"Here is your operation result: {numberOne} {"+"} {numberTwo} {"="} {numberOne + numberTwo}");
        Console.WriteLine();
        Console.WriteLine("Thank you, press any key to exit the program.");
        Console.ReadKey();
        break;
    case 3:
        Console.WriteLine($"Here is your operation result: {numberOne} {"*"} {numberTwo} {"="} {numberOne * numberTwo}");
        Console.WriteLine();
        Console.WriteLine("Thank you, press any key to exit the program.");
        Console.ReadKey();
        break;
    case 4:
        Console.WriteLine($"Here is your operation result: {numberOne} {"/"} {numberTwo} {"="} {numberOne / numberTwo}");
        Console.WriteLine();
        Console.WriteLine("Thank you, press any key to exit the program.");
        Console.ReadKey();
        break;
    default:
        Console.WriteLine("Entered value is invalid, press any key to exit the program.");
        Console.ReadKey();
        break;

}




// See https://aka.ms/new-console-template for more information

Console.Write("Please enter first number: ");
string Number1 = Console.ReadLine();
Console.Write("Please enter second number: ");
string Number2 = Console.ReadLine();
Console.Write("Please enter operation sign: ");
string Operation = Console.ReadLine();

bool correctNumber1 = double.TryParse(Number1, out double number1);
bool correctnumber2 = double.TryParse(Number2, out double number2);
bool correctOperation = char.TryParse(Operation, out char operation);

if (correctNumber1 && correctnumber2 && correctOperation)
{
    switch (operation)
    {
        case '+':
            Console.WriteLine($"Result: {number1} + {number2} = {number1 + number2}");
            break;
        case '-':
            Console.WriteLine($"Result: {number1} - {number2} = {number1 - number2}");
            break;
        case '/':
            Console.WriteLine($"Result: {number1} / {number2} = {number1 / number2}");
            break;
        case '*':
            Console.WriteLine($"Result: {number1} * {number2} = {number1 * number2}");
            break;
        case '%':
            Console.WriteLine($"Result: {number1} % {number2} = {number1 % number2}");
            break;
        case 'p':
            Console.WriteLine($"Result: first number is {number1}, second number is {number2}");
            break;
        case 'b':
            if (number1 > number2) { Console.WriteLine($"Result: first number ({number1}) is bigger"); }
            else { Console.WriteLine($"Result: second number ({number2}) is bigger"); }
            break;
        case 's':
            if (number1 < number2) { Console.WriteLine($"Result: first number ({number1}) is smaller"); }
            else { Console.WriteLine($"Result: second number ({number2}) is smaller"); }
            break;
        default:
            Console.WriteLine("Incorrect operation");
            break;

    }
}
else
{
    Console.WriteLine("Incorrect numbers or operation");
}
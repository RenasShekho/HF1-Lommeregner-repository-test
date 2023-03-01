int number = 0;
double result = 0;
double first = 0;
double second = 0;
string mathOperator = "";

void Start()
{
    Console.WriteLine("Welcome to The Calculator");
    Console.WriteLine("Choose your operator:");
    Console.WriteLine("1 - Plus | 2 - Minus | 3 - Multiply | 4 - Divide");
    Console.WriteLine();
    number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Your first number?  ");
    first = Convert.ToInt32(Console.ReadLine());
    Console.Write("Your second number? ");
    second = Convert.ToInt32(Console.ReadLine());
}
void Operator()
{
    switch (number)
    {
        case 1:
            result = first + second;
            mathOperator = "+" ;
            break;
        
        case 2:
            result = first + second;
            mathOperator = "-";
            break;

        case 3:
            result = first * second;
            mathOperator = "*";
            break;

        case 4:
            result = first / second;
            mathOperator = "/";
            break;

        default:
            Console.WriteLine("Fejl, prøv igen.");
            break;
    }
}


//Start 

Start();
Operator();
Console.WriteLine();
Console.WriteLine(first + " " + mathOperator + " "+ second + " = "+ result);



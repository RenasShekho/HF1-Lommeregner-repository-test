int Number = 0;
double Result = 0;
double First = 0;
double Second = 0;

void Start()
{
    Console.WriteLine("Welcome to The Calculator");
    Console.WriteLine("Choose your operator:");
    Console.WriteLine("1 - Plus | 2 - Minus | 3 - Multiply | 4 - Divide");
    Number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Whats the first number?");
    First = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Whats the second number?");
    Second = Convert.ToInt32(Console.ReadLine());
}
void Operator()
{
    if (Number == 1)
    {
    
    }
}

//Start 

Start();

Console.WriteLine(Number);

switch (Number)
{
    case 1:
        
        break;
    case 2:

        break;

    case 3:
        break;

    case 4:
        break;

    default:
        Console.WriteLine("Fejl");
        break;
}

int Number = 0;
double Result = 0;
double First = 0;
double Second = 0;
String mathoperator = "";
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
    switch (Number)
    {
        case 1:
            Result = First + Second;
            mathoperator = "+" ;
            break;
        
        case 2:
            Result = First - Second;
            mathoperator = "-";
            break;

        case 3:
            Result = First * Second;
            mathoperator = "*";
            break;

        case 4:
            Result = First / Second;
            mathoperator = "/";
            break;

        default:
            Console.WriteLine("Fejl, prøv igen.");
            Operator();
            break;
    }
}


//Start 

Start();
Operator();
Console.WriteLine(First + " " + mathoperator + " "+ Second + " = "+ Result);

////Console.WriteLine(Result);



int Operator = 0;
double Result = 0;






Console.WriteLine("Welcome to The Calculator");
Console.WriteLine("Choose your operator:");
Console.WriteLine("1 - Plus | 2 - Minus | 3 - Multiply | 4 - Divide");
Operator = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Operator);

switch (Operator)
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

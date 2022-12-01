Console.Write("Please enter your first value: ");
double value1 = double.Parse(Console.ReadLine()!);

Console.Write("Please enter your second value: ");
double value2 = double.Parse(Console.ReadLine()!);

Console.Write("Please enter your result(rounded of two frictional digits): ");
double result = double.Parse(Console.ReadLine()!);

if (value1 + value2 == result) 
{
    Console.WriteLine("The operator is plus. ");
}
else if (value1 - value2 == result || value2 - value1 == result) 
{
    Console.WriteLine("The operator is minus. ");
}
else if (Math.Round((value1 / value2),2) == result || Math.Round((value2 / value1),2) == result) 
{
    Console.WriteLine("The operator is divided. ");
}
else if (value1 * value2 == result) 
{
    Console.WriteLine("The operator is multiply. ");
}
else if (value1 % value2 == result || value2 % value1 == result) 
{
    Console.WriteLine("The operator is modulo. ");
}
else if (Math.Pow(value1, value2) == result || Math.Pow(value2, value1) == result) 
{
    Console.WriteLine("The operator is exponentiation. ");
}


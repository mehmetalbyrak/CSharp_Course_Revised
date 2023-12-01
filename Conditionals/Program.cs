int number = 11;

/*
 if (number == 10)
{
    Console.WriteLine("Number is 10");
}
else if (number == 20)
{
    Console.WriteLine("Number is 20");
}
else
{
    Console.WriteLine("Number is not 10");
}
 */

/*
switch (number)
{
    case 10:
        Console.WriteLine("Number is 10");
        break;
    case 20:
        Console.WriteLine("Number is 20");
        break;
    default:
        Console.WriteLine("Number is not 10");
        break;
}

*/

/*
if (number >= 0 && number <= 100)
{
    Console.WriteLine(("Number is between 0-100"));
}else if (number > 100 && number <= 200)
{
    Console.WriteLine("Number is between 101-200");
}else if (number > 200 || number < 10)
{
    Console.WriteLine("Number is less than 0 or greater than 200");
}

Console.ReadLine();

*/


//nested if
if (number < 100)
{
    if (number > 90 && number < 95)
    {
        Console.WriteLine("Number is between 90 and 95");
    }
    else
    {
        Console.Write("*****");
    }
}
else if (number >= 100)
{
    Console.WriteLine("Number is equal or greater than 100");
}
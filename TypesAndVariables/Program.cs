Console.WriteLine("Hello World!");
//data types

double number5 = 10.4;
decimal number6 = 10;

char character = 'A';
bool condition = false; // or true
byte number4 = 255;
short number0 = 32767;
int number1 = 2147483647;
long number2 = 2147483648;
long number3 = 9223372036854775807;
var number7 = 10;
number7 = 'A';
// you can't do that at here  --> number7 = "A";


Console.WriteLine("Number1 is {0}", number1);
Console.WriteLine("Number2 is {0}", number2);
Console.WriteLine("Number3 is {0}", number3);
Console.WriteLine("Number0 is {0}", number0);
Console.WriteLine("Number4 is {0}", number4);
Console.WriteLine("Character is : {0}", (int)character);
Console.WriteLine("Number5 is {0}", number5);
Console.WriteLine("Number6 is {0}", number6);
Console.WriteLine("Number7 is {0}", number7);
Console.WriteLine("Condition is {0}", condition);
Console.WriteLine((int)Days.Friday);


Console.ReadLine();


//enum usage
enum Days
{
    Monday=10, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}
//Methods

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Add();
            Add();
            Add();

            var result = Add2(4);*/
            
            /*

            int number1; //--> usage for out
            //int number1 = 20; --> usage for ref
            int number2 = 100;
            //var result2 = Add3(ref number1, number2);
            var result2 = Add3(out number1, number2);
            Console.WriteLine(result2); //output is 130
            Console.WriteLine(number1); // output is 30 because we have used ref keyword
            */
            
            Console.WriteLine((Multiply(2,4))); // 8
            Console.WriteLine(Multiply(2, 4, 5)); // 40
            Console.WriteLine(Add4(1,2,3,4,5,6)); // 20
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int x, int number1=20, int number2=30)
        {
            var result = x + number1 + number2;
            return result;

        }

        static int Add3(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3; //method overloading
        }

        static int Add4(int number, params int[] numbers)  //params usage
        {
            return numbers.Sum();
        }
        
        
    }
}
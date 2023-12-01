namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        /*
        string student1 = "Engin";
        string student2 = "Derin";
        string student3 = "Salih";
        */

        string[] students = new string[3];
        students[0] = "Engin";
        students[1] = "Derin";
        students[2] = "Salih";

        //string[] students2 = new[] { "Engin", "Derin", "Salih" };
        string[] students2 = { "Engin", "Derin", "Salih" };
        
        foreach (var student in students2)
        {
            Console.WriteLine(student);
        }

        // students2[3] = "Ahmet"; // --> out of index error
        
        /*
        Console.WriteLine("**********");

        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
        */
        
        // multidimensional arrays

        string[,] regions = new string [7, 3] //seven rows and three column
        {
            { "İstanbul", "İzmit", "Balıkesir" },
            { "Ankara", "Konya", "Kırıkkale" },
            { "Antalya", "Adana", "Mersin" },
            { "Rize", "Trabzon", "Samsun" },
            { "İzmir", "Muğla", "Manisa" },
            { "Gaziantep", "Diyarbakır", "Şanlıurfa" },
            { "Van", "Ağrı", "Erzurum" },
        };

        for (int i = 0; i <= regions.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= regions.GetUpperBound(1); j++)
            {
                Console.WriteLine(regions[i,j]);
            }
            Console.WriteLine("************");
        }
    }
}
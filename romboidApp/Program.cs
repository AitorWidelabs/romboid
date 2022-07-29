using System;

namespace romboidApp
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            Console.WriteLine("Please enter a odd number between 3 and 47");
            int size = Convert.ToInt32(Console.ReadLine());
            if (size % 2 == 0) {
                size++;
            }
            string[] array = new string[size];
            double round = size / 2;
            int half = (int)Math.Round(round);
            Rombo Rombo1 = new Rombo(array, half);
            Rombo1.write();
            Console.WriteLine();
            CurryBorder curry = new CurryBorder(array, half);
            curry.write();
            Console.WriteLine();
            PaperDragon dragon = new PaperDragon(array, half);
            dragon.write();
        }
    }
}

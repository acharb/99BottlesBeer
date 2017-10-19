using System;

namespace BottlesBeer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int count = 99;
            while (count>1)
            {
                Console.WriteLine(count + " bottles of beer on the wall " + count + " bottles of beer,");
                count -= 1;
                Console.WriteLine("take one down, pass it around " +count+ " bottles of beer on the wall." );
                Console.WriteLine();
            }
            Console.WriteLine(count+ " bottle of beer on the wall " + count + " bottle of beer, ");
            count -= 1;
            Console.WriteLine("take one down, pass it around " + count + " bottles of beer on the wall.");
        }
    }
}

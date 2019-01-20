using System;

namespace Muffins
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lisa is cooking muffins. The recipe calls for 7 cups of sugar. 
            //She has already put in 2 cups. How many more cups does she need to put in?

            int requiredSugar = 7;
            int addedSugar = 2;
            int howMuchMoreSugar;

            howMuchMoreSugar = requiredSugar - addedSugar;
            Console.WriteLine(howMuchMoreSugar + " more cups of sugar needed, better run to the store!");
        }
    }
}

using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            DVD newDVD = new DVD("test");
            CD newCD = new CD("test2", 700);

            // TODO: Call each CD and DVD method to verify that they work as expected.
            newDVD.SpinDisc();
            newDVD.StoreData();
            newCD.SpinDisc();
            newCD.StoreData();
            Console.WriteLine(newCD.Name);
            Console.WriteLine(newDVD.Name);
            Console.WriteLine(newCD.MaxStorage);
            Console.WriteLine(newCD.StorageRemaining(300));
            Console.WriteLine(newCD);

        }
    }
}

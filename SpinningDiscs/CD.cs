using System;
namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.

        int minSpeed = 200;
        int maxSpeed = 500;
        int maxStorage = 700;
        public void SpinDisc()
        {
            Console.WriteLine("A CD spins at a rate of " + minSpeed + " - " + maxSpeed + " rpm.");
        }
        public void StoreData()
        {
            Console.WriteLine("A CD stores " + maxStorage + " MB of data");
        }

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
        public CD(string name) : base(name)
        {
        }
        public CD(string name, int maxStorage) : base(name, maxStorage)
        {
        }
        public CD(string type, string name, int maxStorage) : base(type, name, maxStorage)
        {
        }


    }
}

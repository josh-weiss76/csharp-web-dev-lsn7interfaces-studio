using System;
namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.
        int minSpeed = 570;
        int maxSpeed = 1600;
        int maxStorage = 4700;
        public void SpinDisc()
        {
            Console.WriteLine("A DVD spins at a rate of " + minSpeed + " - " + maxSpeed + " rpm.");
        }
        public void StoreData()
        {
            Console.WriteLine("A DVD stores " + maxStorage + " MB of data");
        }

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
        public DVD(string name) : base(name)
        {
        }
        public DVD(string name, int maxStorage) : base(name, maxStorage)
        {
        }
        public DVD(string type, string name, int maxStorage) : base(type, name, maxStorage)
        {
        }

    }
}

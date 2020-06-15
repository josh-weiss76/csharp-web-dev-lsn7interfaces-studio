using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int MaxStorage { get; set; }

        public BaseDisc(string name)
        {
            Name = name;
        }

        public BaseDisc (string name, int maxStorage)
        {
            Name = name;
            MaxStorage = maxStorage;
        }

        public BaseDisc(string type, string name, int maxStorage)
        {
            Type = type;
            Name = name;
            MaxStorage = maxStorage;
        }

        public double StorageRemaining(double storageUsed)
        {
            double storageLeft = MaxStorage - storageUsed ;
            return storageLeft;

        }

        public override string ToString()
        {
            if (Name == null)
            {
                Name = "unknown";
            }
            if (Type == null)
            {
                Type = "unknown";
            }
            
            string label = Name + " is a " + Type + " with a maximum storage of " + MaxStorage + " MB.";
            return label;
        }
    }
}

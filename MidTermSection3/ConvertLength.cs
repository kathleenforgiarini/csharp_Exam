using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermSection3
{
    internal class ConvertLength
    {
        private double length;

        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        public ConvertLength()
        {
            this.Length = 0;
        }
        public double mToCm()
        {
            return length * 100;
        }

        public double mToYd()
        {
            return length * 1.0936;
        }

        public double kmToM()
        {
            return length * 1000;
        }

        public double kmToMile()
        {
            return length * 0.6214;
        }

    }
}

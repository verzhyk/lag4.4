using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newLaba4Vlad
{
    public abstract class Number
    {
        public double FirstNum { get; set; }
        public double SecondNum { get; set; }

        public abstract double Sum();
        public abstract double Minus();
        public abstract double Devide();
        public abstract double Multiply();
    }
}

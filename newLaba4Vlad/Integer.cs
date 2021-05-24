using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newLaba4Vlad
{
    public class Integer : Number
    {
        public Integer(int num1, int num2)
        {
            FirstNum = num1;
            SecondNum = num2;
        }
        public override double Sum()
        {
            return FirstNum + SecondNum;
        }

        public override double Minus()
        {
            return FirstNum - SecondNum;
        }

        public override double Devide()
        {
            if (SecondNum != 0) return FirstNum / SecondNum;
            else return 0;
        }

        public override double Multiply()
        {
            return FirstNum * SecondNum;
        }
    }
}

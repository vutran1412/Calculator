using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public decimal currentValue;
        public decimal enterValue;

        public void Add(decimal enterValue)
        {
            currentValue += enterValue;
        }

        public void Subtract(decimal enterValue)
        {
            currentValue -= enterValue;
        }

        public void Multiply(decimal enterValue)
        {
            currentValue *= enterValue;
        }

        public void Divide(decimal enterValue)
        {
            currentValue /= enterValue;
        }

        public void Reciprocal(decimal enterValue)
        {
            currentValue = 1 / enterValue;
        }

        public void SquareRoot(decimal enterValue)
        {
            currentValue = (decimal)Math.Sqrt(Convert.ToDouble(enterValue));
        }

        public decimal Equals()
        {
            return currentValue;
        }

        public void Clear()
        {
            currentValue = 0;
            enterValue = 0;
        }

        public decimal CurentValue
        {
            set
            {
                currentValue = value;
            }
            get
            {
                return currentValue;
            }
        }

        public decimal EnterValue
        {
            set
            {
                enterValue = value;
            }
            get
            {
                return enterValue;
            }
        }
        




    }
}

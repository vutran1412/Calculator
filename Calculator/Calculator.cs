using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{
    public class Calculator
    {
        public decimal num_1;
        public decimal num_2;
        public string operation;
        public decimal solution;

        public Calculator() { }

        public void EnterValue(decimal num_1, string operation, decimal num_2)
        {
            Num_1 = num_1;
            Operation = operation;
            Num_2 = num_2;

        }

        public decimal Num_1
        {
            get
            {
                return num_1;
            }
            set
            {
                num_1 = value;
            }
        }

        public decimal Num_2
        {
            get
            {
                return num_2;
            }
            set
            {
                num_2 = value;
            }
        }

        public string Operation
        {
            get
            {
                return operation;
            }
            set
            {
                operation = value;
            }
        }

        public string Add()
        {
            operation = "+";
            return operation;
        }

        public string Subtract()
        {
            operation = "-";
            return operation;
        }

        public string Multiply()
        {
            operation = "*";
            return operation;
        }

        public string Divide()
        {
            operation = "/";
            return operation;
        }

        public decimal Reciprocal(decimal num_1)
        {
            solution = 1 / num_1;
            return solution;
        }

        public decimal SquareRoot(decimal num_1)
        {
            solution = (decimal)Math.Sqrt(Convert.ToDouble(num_1));
            return solution;
        }

        public void Clear()
        {
            num_1 = 0;
            operation = "";
            num_2 = 0;
            solution = 0;
        }


        public decimal Equal()
        {
            switch(operation)
            {
                case "+":
                    solution = Decimal.Add(num_1, num_2);
                    return solution;
                case "-":
                    solution = Decimal.Subtract(num_1, num_2);
                    return -(solution);
                case "*":
                    solution = Decimal.Multiply(num_1, num_2);
                    return solution;
                case "/":
                    solution = Decimal.Divide(num_2, num_1);
                    return solution;
                default:
                    return solution;
            }
        }

        

        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Application: Calculator
 * Author: Vu Tran
 */
namespace Calculator
{
    // The Calculator class, this is where all the calculator's functions are implemented
    public class Calculator
    {
        // The two operands that the calculator class will accept
        public decimal num_1;
        public decimal num_2;
        // The operator will be assigned as a string
        public string operation;
        // The solution will be returned as a decimal
        public decimal solution;

        // Empty Constructor 
        public Calculator() { }

        // The EnterValue method accepts the two operands and the operation that user wants to execute
        public void EnterValue(decimal num_1, string operation, decimal num_2)
        {
            Num_1 = num_1;
            Operation = operation;
            Num_2 = num_2;

        }

        // Getters and Setters
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

        /* These methods set the pending operation to the user's desired operation 
         * and returns the operation as a string*/
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

        /* The Reciprocal operation does not need a second operand, 
        since user only needs the first input to calculate the inverse.
        The method returns a decimal value. */
        public decimal Reciprocal(decimal num_1)
        {
            solution = 1 / num_1;
            return solution;
        }
        
        /* The SquareRoot operation does not need a second operand, 
         * since we only need the first input. The method returns a decimal value. */
        public decimal SquareRoot(decimal num_1)
        {
            solution = (decimal)Math.Sqrt(Convert.ToDouble(num_1));
            return solution;
        }

        // This method clears out all the data from the calculator class
        public void Clear()
        {
            num_1 = 0;
            operation = "";
            num_2 = 0;
            solution = 0;
        }

        /* The Equal method is where all the basic arithmetic calculations are performed,
        the Decimal class has several useful built in methods
        https://msdn.microsoft.com/en-us/library/system.decimal(v=vs.110).aspx */
        public decimal Equal()
        {
            switch(operation) // switch case statements are more appropriate in this application
            {
                case "+":
                    solution = Decimal.Add(num_1, num_2);
                    return solution;
                case "-":
                    solution = Decimal.Subtract(num_1, num_2);
                    return -(solution); // 
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

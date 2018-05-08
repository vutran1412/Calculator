using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    // MemoryCalculator class inherits attributes of the Calculator base class
    class MemoryCalculator: Calculator
    {
        // Value stored in MemoryCalculator
        private decimal storedValue;

        // Constructors
        public MemoryCalculator() { }

        public MemoryCalculator(decimal storedValue): base() { }

        // Getters and Setters
        public decimal StoredValue
        {
            get
            {
                return storedValue;
            }
            set
            {
                storedValue = value;
            }
        }


        // Memory Calculator methods
        public void MemmoryStore(decimal currentValue) 
        {
            storedValue = currentValue;
        }

        public decimal MemoryRecall()
        {
            return storedValue;
        }

        public void MemoryAdd(decimal currentValue)
        {
            storedValue += currentValue;

        }

        public void MemoryClear()
        {
            storedValue = 0;
        }

        // Overide method to display the storedValue
        public override string ToString()
        {
            return storedValue.ToString();
        }

    }
}

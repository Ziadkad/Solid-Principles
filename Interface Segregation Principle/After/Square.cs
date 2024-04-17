using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.After
{
    //In this example, we properly segregated the Shape interface into smaller interfaces based on related functionality.This adheres to the ISP and makes your code more flexible and maintainable.
    internal class Square : Shape
    {
        public int Side { get; set; }
        public float Area()
        {
            return Side * Side;
        }
    }
}

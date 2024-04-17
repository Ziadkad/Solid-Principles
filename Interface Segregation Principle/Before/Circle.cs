using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Before
{
    internal class Circle : Shape
    {
        public int Rad { get; set; }

        public float Area()
        {
            return (float)(Math.PI * Rad * Rad);
        }

        public int Radius()
        {
            return Rad;
        }
    }
}

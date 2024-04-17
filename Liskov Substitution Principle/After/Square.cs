using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle.After
{
    internal class Square : Shape
    {
        public int Side { get; set; }
        public float Area()
        {
            return Side * Side;
        }
    }
}

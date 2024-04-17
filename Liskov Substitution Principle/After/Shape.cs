using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle.After
{
    // we remove Raduis() method and it worked
    internal interface Shape
    {
    public abstract float Area();
    }
}

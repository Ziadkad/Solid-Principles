using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Before
{
    //In this example, the Shape interface has too many methods. The Square class is forced to implement all of them, even though they don't have a raduis. This violates the ISP because the Vehicle interface is not properly segregated into smaller interfaces based on related functionality.
    internal interface Shape
    {
    public abstract float Area();
    public abstract int Radius();
    }
}

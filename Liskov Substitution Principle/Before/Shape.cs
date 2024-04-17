using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle.Before
{
    //In the given example, the interface Shape has two methods, Area() and Radius(). Two classes implement this interface, Circle and Square.However, the Square class throws an AssertionError in the Radius() method because it has no raduis. .
    internal interface Shape
    {
    public abstract float Area();
    public abstract int Radius();
    }
}

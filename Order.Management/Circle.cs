using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class Circle : Shape
    {
        // you use camel case for circlePrice and upper case for Circle. For consistency, pick either lower case or camel case for classes/variables/parameters
        public int circlePrice = 3;
        public Circle(int red, int blue, int yellow)
        {
            Name = "Circle";
            base.Price = circlePrice;
            AdditionalCharge = 1;
            base.NumberOfRedShape = red;
            base.NumberOfBlueShape = blue;
            base.NumberOfYellowShape = yellow;
        }

        // for all the returns in the below function calls, consider using variables, so that if you need to change a value, you dont have to hunt for it, and only change in the one place.
        public override int Total()
        {
            return RedCirclesTotal() + BlueCirclesTotal() + YellowCirclesTotal();
        }

        public int RedCirclesTotal()
        {
            return (base.NumberOfRedShape * Price);
        }
        public int BlueCirclesTotal()
        {
            return (base.NumberOfBlueShape * Price);
        }
        public int YellowCirclesTotal()
        {
            return (base.NumberOfYellowShape * Price);
        }
    }
}

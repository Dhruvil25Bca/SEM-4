using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    public abstract class Class1
    {
        public abstract double area();

    }
    public class rec:Class1
    {
        override public double area()
        {
            double length=15;
            double width=25;
            return(length*width);
        }
    }
    public class tri:Class1
    {
        override public double area()
        {
            double length=18;
            double width=12;
            return((length*width)/2);
        }
    }
    public class square:Class1
    {
        override public double area()
        {
            double length=20;
            return(length*length);
        }
    }
}

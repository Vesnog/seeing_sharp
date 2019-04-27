using System;

namespace MyProgram
{
    class Rectangle
    {

        // member variables
        double length;
        double width;


        public void Acceptdetails(double l, double w)
        {
            length = l;
            width = w;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Acceptdetails(4.5, 3);
            r.Display();
            Console.ReadLine();
        }
    }
}
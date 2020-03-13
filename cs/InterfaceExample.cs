using System;

namespace InterfaceExampleApplication
{
    interface IShape
    {
        double X { get; set; }
        double Y { get; set; }
        double Area { get; }
        string Color { get; set; }
        void Draw();
    }

    class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle() {}
        public Rectangle(int length, int width)
        {
            this.Length = length;
            this.Width = width;
        }
        public double Area
        {
            get
            {
                return Length * Width;
            }
        }
        public double X { get; set; }
        public double Y { get; set; }
        public string Color { get; set; }
        public void Draw()
        {
            Console.WriteLine("Draw {0} rectangle at ({1}, {2}). Area is {3}.", Color, X, Y, Area);
        }
    }
    class InterfaceExampleProgram
    {
        static void Main(string[] args)
        {
            // IShape shape1 = new Rectangle(10, 20);
            // shape1.X = 100;
            // shape1.Y = 200;
            // shape1.Color = "red";
            // shape1.Draw();

            Rectangle rectangle = new Rectangle();
            rectangle.Length = 10;
            rectangle.Width = 20;
            IShape shape1 = rectangle;
            shape1.X = 100;
            shape1.Y = 200;
            shape1.Color = "red";
            shape1.Draw();
        }
    }
}
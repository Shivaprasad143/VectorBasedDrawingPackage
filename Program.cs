using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace VectorBasedDraw
{
    public interface Draw
    {
        void Show();
    }

    class Shape
    {
        private int X { get; set; }
        private int Y { get; set; }

        public Shape(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public string GetLocation()
        {
            return "(" + this.X + "," + this.Y + ")";
        }
    }

    class Square : Shape, Draw
    {
        public Square(int x, int y) : base(x, y)
        {
        }

        public int size { get; set; }

        public void Show()
        {
            Console.WriteLine("{0} {1}  size={2}", typeof(Square).Name, base.GetLocation(), this.size);
        }
    }

    class Rectangle : Shape, Draw
    {

        public int Width { get; set; }

        public int Height { get; set; }

        public Rectangle(int x, int y) : base(x, y)
        {
        }
        public void Show()
        {
            Console.WriteLine("{0} {1} Width={2} Height={3} ", typeof(Rectangle).Name, base.GetLocation(), this.Width, this.Height);
        }

        class Textbox : Shape, Draw
     {
         
         public string Text { get; set; }

         public int Width { get; set; }

         public int Height { get; set; }

         public Textbox(int x, int y) : base(x, y)
         {
         }


            public  void Show()
         {
             Console.WriteLine("{0} {1} Width={2} Height={3} Text={4}", typeof(Textbox).Name, base.GetLocation(), this.Width, this.Height, "\"" + this.Text + "\"");
         }
     }
       
    }

    class Ellipse : Shape, Draw
    {

        public Ellipse(int x, int y) : base(x, y)
        {
        }

        public int HDiameter { get; set; }

        public int VDiameter { get; set; }

        public void Show()
        {
            Console.WriteLine("{0} {1} diameterH={2} diameterY={3}", typeof(Ellipse).Name, base.GetLocation(), this.HDiameter, this.VDiameter);
        }
    }

    class Circle : Shape, Draw
    {

        public Circle(int x, int y) : base(x, y)
        {
        }

        public int size { get; set; }

        public void Show()
        {
            Console.WriteLine("{0} {1} size={2}", typeof(Circle).Name, base.GetLocation(), this.size);
        }
    }



    class Program
    {

        static void Main(string[] args)
        {


            var widgets = new List<Draw>()
        {
            new Rectangle(10, 10) { Width = 30, Height = 40 },
            new Square(15, 30) { size = 35 },
            new Ellipse(100, 150) { HDiameter = 300, VDiameter = 200 },
            new Circle(1, 1) { size = 300 },
        //    new Textbox(5, 5) { Width = 200, Height = 100, Text = "Sample text!" }
        };


            foreach (var widget in widgets)
            {
                try
                {
                    widget.Show();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            Console.ReadKey();
        }
    }
}



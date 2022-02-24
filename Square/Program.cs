using System;

namespace Square
{
    public class Square
    {

        private double side;

        private double area;
        public double Side
        {

            get { return this.side; }

        }
        public double Area
        {

            get { return this.area; }
        }
        public Square(double length)
        {
           
            this.side = length;
            this.area = SquareArea();
        }
        private double SquareArea()
        {


            return Math.Pow(this.side, 2);
        }
    }
    public class SquareSide
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("{0}\t{1}\t{2}", "Number ", "Side Length ", "Area");


            Square[] squares = new Square[10];

            for (int i = 1; i < squares.Length; i++)
            {

                squares[i] = new Square(i);


                Square sqr = squares[i];



                Console.WriteLine("{0}\t{1,11}\t{2,4}", i, sqr.Side, sqr.Area);
            }
        }
    }
}

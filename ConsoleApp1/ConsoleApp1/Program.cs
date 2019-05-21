using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface ICircle

    {

        int CalculateDiameter();

    }



    public abstract class Shape

    {

        public string Name { get; set; }



        protected Shape(string name)

        {

            Name = name;

        }

    }



    public class Circle : Shape, ICircle

    {

        public int R { get; }



        public Circle(int r, string name) : base(name)

        {

            R = r;

        }



        public int CalculateDiameter()

        {

            return R * 2;

        }

    }



    public class SuperCircle : Circle

    {

        public SuperCircle(int r, string name) : base(r, name)

        {

        }

    }



    class Program

    {

        static void Main(string[] args)

        {

            ICircle circle = new SuperCircle(10, "circle");

            Console.WriteLine(circle.CalculateDiameter());

        }

    }
}

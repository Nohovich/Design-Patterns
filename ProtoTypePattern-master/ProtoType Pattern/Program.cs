using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType_Pattern
{
    class Program
    {
        /// <summary>
        /// Prototype is a design pattern that allows cloning objects, even complex ones,
        /// without coupling to their specific classes.
        /// </summary>
        static void Main(string[] args)
        {
            // creating new point
            Point secretPoint = new Point(4.5f, 9.876f);

            // cloning a point
            Point clonedPoint = secretPoint.Clone();

            // changing the value of the clone point
            ShareSecretData(clonedPoint);

            // the original point value haven't changed
            Console.WriteLine(secretPoint);

            // creating new line
            Line l1 = new Line(new Point(10, 5), new Point(100, 100));
            Console.WriteLine("Before ");
            // the value of the line before cloning
            Console.WriteLine(l1);

            // cloning line
            Line cloned_line = l1.Clone();

            // // changing the value of the point clone line
            ShareSecretData(cloned_line);
            Console.WriteLine("After ");
            // the value of the line after change been made to the clone
            Console.WriteLine(l1);

            Console.WriteLine("=============================================");
            Console.WriteLine();
            LineW l2 = new LineW(new Point(4, 5), new Point(6, 7));

            Console.WriteLine("=============================================");
            Console.WriteLine();
            Employee e = new Employee() { Id = 1, FName = "Assi", LName = "Cohen" };
            e.Print();
            int x = 5;
            Console.WriteLine(x.Div2());
            Employee new_employee = e.CloneObject<Employee>();
            Console.ReadKey();

        }
        /// <summary>
        /// changing the value of a point 
        /// </summary>
        /// <param name="p"></param>
        static void ShareSecretData(Point p)
        {
            Console.WriteLine("Register point");
            p.X = -999;
            Console.WriteLine($"Point in ShareSecretData {p}");
        }

        /// <summary>
        /// changing the value of a point inside a line 
        /// </summary>
        /// <param name="l1"></param>
        static void ShareSecretData(Line l1)
        {
            Console.WriteLine("Register line");
            l1.P1.X = -999;
            Console.WriteLine($"Line in ShareSecretData {l1}");
            Console.ReadKey();
        }
    }
}

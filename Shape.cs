using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17_27July
{
   
    

        public class Shape
        {
            public string ShapeType { get; protected set; }

            public virtual double Area
            {
                get { return 0; }
            }

            public virtual double Perimeter
            {
                get { return 0; }
            }

            public void PrintInfo()
            {
                Console.WriteLine($"Shape Type: {ShapeType}");
                Console.WriteLine($"Area: {Area}");
                Console.WriteLine($"Perimeter: {Perimeter}");
            }
        }
    }


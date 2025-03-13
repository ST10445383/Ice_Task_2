using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Task_2
{
  
        // Abstract Shape class
        abstract class Shape
        {
            public string Name { get; set; }

            // Constructor
            protected Shape(string name)
            {
                Name = name;
            }

            // Virtual Display Method
            public virtual void Display()
            {
                Console.WriteLine($"Shape: {Name}");
            }
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDesign.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            PersistentCarFactory carFactory = new PersistentCarFactory();
            carFactory.LoadCars();
            carFactory.DumpCars();
        }
    }
}

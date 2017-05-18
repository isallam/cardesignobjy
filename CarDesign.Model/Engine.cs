using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDesign.Model
{
    public class Engine
    {
        public Engine()
        {
        }

        public List<CarDesign.Model.Cylinder> Cylinders
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public double HorsePower
        {
            get;
            set;
        }
    }
}

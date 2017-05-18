using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDesign.Model
{
    public  class Cylinder
    {
        public Cylinder()
        { }

        public int Id { get; set; }

        public CylinderHead Head
        {
            get;
            set;
        }
    }

}

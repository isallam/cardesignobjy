using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDesign.Model
{
    public class Wheel
    {
        public Wheel()
        {
        }

        public int Id { get; set; }
        public double TirePressure { get; set; }
        public WHEEL_LOCATION Location { get; set; }
        public Rotor Rotor { get; set; }
        public Stator Stator { get; set; }
    }

    public enum WHEEL_LOCATION
    {
        Front_Right,
        Front_Left,
        Rear_Right,
        Rear_Left
    }
}

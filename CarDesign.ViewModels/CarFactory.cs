using CarDesign.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CarDesign.ViewModels
{
    public static class CarFactory
    {
        static CarFactory()
        {
            Cars = new List<Car>();
            LoadCars();

            //int id = Cars[0].Engine.Cylinders[0].Id;
            //foreach(Car car in Cars)
            //{
            //    foreach(Cylinder cylinder in car.Engine.Cylinders)
            //    {
            //        id = cylinder.Id;
            //    }
            //}
        }


        public static void SaveXML()
        {
            Catalog catalog = new Catalog();
            catalog.Cars = Cars;
            catalog.WriteToXML();
        }

        public static void WriteToXML(this object obj)
        {
            var dialog = new Microsoft.Win32.SaveFileDialog();
            dialog.InitialDirectory = @"C:\";
            dialog.Title = "File Save";  

            XmlSerializer writer = new XmlSerializer(obj.GetType());
            StreamWriter file = new StreamWriter(dialog.FileName);
            writer.Serialize(file, obj);
            file.Close();
        }

        public static List<Car> Cars { get; set; }

        /// <summary>
        /// Had hard coded data - Needs to call database for data
        /// </summary>
        private static void LoadCars()
        {
            Cars.Add(new Car
            {
                Id = 1,
                Manufacturer = "Honda",
                Model = "Accord",
                Engine = new Engine
                         {
                             Cylinders = AddCylinders(4),
                             Description = "V4",
                             HorsePower = 2500
                         },
                Wheels = AddWheels(),
                Year = 2017
            });


            Cars.Add(new Car
            {
                Id = 2,
                Manufacturer = "Honda",
                Model = "Accord",
                Engine = new Engine
                {
                    Cylinders = AddCylinders(6),
                    Description = "V6",
                    HorsePower = 3500
                },
                Wheels = AddWheels(),
                Year = 2017
            });

        }


        private static List<Cylinder> AddCylinders(int numberOfCylinders)
        {
            List<Cylinder> cylinders = new List<Cylinder>();
            for (int i = 0; i < numberOfCylinders; i++)
                cylinders.Add(new Cylinder { Id=i+1, Head = new CylinderHead() });
            return cylinders;
        }

        private static List<Wheel> AddWheels(int numberOfWheels =4)
        {
            List<Wheel> wheels = new List<Wheel>();
            for (int i = 0; i < numberOfWheels; i++)
                wheels.Add(new Wheel { Id = i + 1, TirePressure=30.4+i/2, Rotor = new Rotor(), Stator = new Stator(), Location = (WHEEL_LOCATION)i });
            return wheels;
        }

    }

    public class Catalog
    {
        public Catalog()
        {
        }

        public List<Car> Cars { get; set; }
    }

    public static class ExtensionMethods
    {
        /// <summary>
        /// This method serializes the object to xml and returns a string in XML format
        /// </summary>
        /// <param name="obj">Object to be sesialized into XML format</param>
        /// <returns>Returns the string in XML format</returns>
        public static string ToXML(this object obj)
        {
            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, obj);
            return writer.ToString().Replace("utf-16", "utf-8");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Objectivity.Db;
using CarDesign.Model;
using System.Transactions;
using System.Configuration;

namespace CarDesign.Test
{
    public class PersistentCarFactory
    {
        private ObjyConnection _connection = null;

        public PersistentCarFactory()
        {
            _Cars = new List<Car>();
        }

        //public ObjyConnection GetConnection(IndexMode indexMode = IndexMode.ExplicitUpdate)
        //{
        //    OpenMode openMode;
        //    MrowMode mrowMode;

        //    if (_connection == null)
        //    {
        //        var federationSpecifier = Objy.Configuration.FederationSpecifiers.DefaultFederationSpecifier;

        //        _connection = new ObjyConnection(federationSpecifier);
        //        _connection.Open(OpenMode.Update, MrowMode.WaitingMROW, indexMode);
        //    }
        //    return _connection;
        //}


        private List<Car> _Cars;
        public List<Car> Cars
        {
            get
            {
                return _Cars;
            }
        }

        /// <summary>
        /// Had hard coded data - Needs to call database for data
        /// </summary>
        public void LoadCars()
        {
            try
            {
                using (var scope = new TransactionScope())
                {
                    //ObjyConnection connection = GetConnection();
                    using (ObjyConnection objyConnection = new ObjyConnection())
                    {
                        objyConnection.Open(OpenMode.Update);
                        // find the existing cars in the DB.
                        var foundCars = objyConnection.Federation.Scan<Car>();
                        foreach (Car carObj in foundCars)
                        {
                            _Cars.Add(carObj);
                        }
                        if (Cars.Count == 0)
                        {
                            // this can be replaced with a car factory method to construct all elements.
                            Engine engine = new Engine(null)
                            {
                                Description = "V4",
                                HorsePower = 2500
                            };
                            AddCylinders(engine, 4);

                            Car car = new Car(null)
                            {
                                Id = 1,
                                Manufacturer = "Honda",
                                Model = "Accord",
                                Year = 2017
                            };
                            car.Engine = engine;
                            AddWheels(car);
                            _Cars.Add(car);

                            car = new Car(null)
                            {
                                Id = 2,
                                Manufacturer = "Honda",
                                Model = "Accord",
                                Engine = new Engine(null)
                                {
                                    Description = "V6",
                                    HorsePower = 3500
                                },
                                Year = 2017
                            };
                            AddCylinders(car.Engine, 6);
                            AddWheels(car);
                            _Cars.Add(car);
                        }
                    }
                    scope.Complete();
                }
            }
            catch (Objectivity.Db.KernelException ex)
            {
                Console.WriteLine("Exception in PersistentCarFactory() {0}", ex.FullMessage);
            }
        }


        private void AddCylinders(Engine engine, uint numberOfCylinders)
        {
            List<Cylinder> cylinders = new List<Cylinder>();
            for (uint i = 0; i < numberOfCylinders; i++)
            {
                Cylinder cylinder = new Cylinder(null) { Id = i + 1, Head = new CylinderHead(null) };
                engine.Cylinders.Add(cylinder);
            }

        }

        private void AddWheels(Car car, int numberOfWheels = 4)
        {
            List<Wheel> wheels = new List<Wheel>();
            for (uint i = 0; i < numberOfWheels; i++)
            {
                Wheel wheel = new Wheel(null)
                {
                    Id = i + 1,
                    TirePressure = 30.4 + i / 2,
                    Rotor = new Rotor(null),
                    Stator = new Stator(null),
                    Location = /*(WHEEL_LOCATION)*/i
                };
                car.Wheels.Add(wheel);
            }
        }


        public void DumpCars()
        {
            try
            {
                using (var scope = new TransactionScope())
                {
                    using (ObjyConnection objyConnection = new ObjyConnection())
                    {
                        objyConnection.Open(OpenMode.Read);
                        foreach (Car car in _Cars)
                        {
                            Console.WriteLine("Car => ID:{0}, Manufacture:{1}, Model:{2}, Year:{3} ",
                                car.Id, car.Manufacturer, car.Model, car.Year);
                            Console.WriteLine("    Engine => Description:{0}, HorsePower:{1}",
                                car.Engine.Description, car.Engine.HorsePower);
                            for (int i = 0; i < car.Engine.Cylinders.Length; i++)
                            {
                                Console.WriteLine("      Cylynder => ID:{0}", car.Engine.Cylinders[i].Id);
                            }
                            for (int i = 0; i < car.Wheels.Length; i++)
                            {
                                Console.WriteLine("    Wheel => ID:{0}, Location:{1}", car.Wheels[i].Id, car.Wheels[i].Location);
                            }
                        }
                    }
                    scope.Complete();
                }
            }
            catch (Objectivity.Db.KernelException ex)
            {
                Console.WriteLine("Exception in PersistentCarFactory() {0}", ex.FullMessage);
            }
        }
    }
}

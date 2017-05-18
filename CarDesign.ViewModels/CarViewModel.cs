using CarDesign.Model;
using Microsoft.Practices.Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CarDesign.ViewModels
{
    public class CarViewModel
    {
        public CarViewModel()
        {
            SelectedCar = Cars.FirstOrDefault();
        }

        public ICommand AddCommand
        {
            get
            {
                return new DelegateCommand(AddCar);
            }
        }
      
        public List<Car> Cars
        {
            get
            {
                return CarFactory.Cars;
            }
        }

        public Car SelectedCar { get; set; }

        private void AddCar()
        {
            CarFactory.Cars.Add(SelectedCar);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDesign.Model
{
    public class Car : INotifyPropertyChanged
    {
        public Car()
        {
        }

        public List<Wheel> Wheels 
        { 
            get; 
            set;
        }

        public Engine Engine 
        { 
            get; 
            set;
        }

        public string Manufacturer
        {
            get;
            set;
        }

        private string _Model;
        public string Model
        {
            get { return _Model; }
            set { _Model = value; OnPropertyChanged("Model"); }
        }

        public int Year
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }


        #region Implementation of INotifyPropertyChanged

        /// <summary>
        /// Event raised when a property of the View Model is changed when it is binded to UI
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Delegate to handle PropertyChangedEvent
        /// </summary>
        /// <param name="propertyName">Name of the Property that is being changed</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        ///  Delegate to handle PropertyChangedEvent
        /// </summary>
        /// <param name="args">Provides data for the PropertyChanged event</param>
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, args);
        }

        #endregion
    }      
}

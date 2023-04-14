using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace pensumsjekkUke4
{
    public class Shop
    {
        public string Name { get; }
        public string Address { get; }
        public List<Car> Cars { get; }

        public Shop(string name, string address, List<Car> cars = null)
        {
            Name = name;
            Address = address;
            Cars = cars ?? new List<Car>();
        }
        public void AddCar(Car car)
        {
            Cars.Add(car);
        }
        public void RemoveCar(string plateNum)
        {
            for (int i = 0; i < Cars.Count; i++)
            {
                if (plateNum == Cars[i].PlateNum) { Cars.Remove(Cars[i]); }
            }
        }
        public List<Car> GetCarsByAge(int year) 
        { 
            List<Car> WantedCars = new List<Car>();
            
            for (int i = 0; i < Cars.Count; i++)
            {
                if (Cars[i].YearMade < year) { WantedCars.Add(Cars[i]); }
            }
            return WantedCars;
        }
        public List<Car> GetCarsByDistance(int distance)
        {
            List<Car> WantedCars = new List<Car>();

            for (int i = 0; i < Cars.Count; i++)
            {
                if (Cars[i].Traveled > distance) { WantedCars.Add(Cars[i]); }
            }
            return WantedCars;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnSimpsonProject1
{
    public class CarLot
    {
        public const double TaxRate = .078; //constant tax rate

        private List<Car>? car_inventory;

        public CarLot()
        {
            car_inventory = new List<Car>();
            StockLotWithDefaultInventory();
        }

        private void StockLotWithDefaultInventory()
        {
            car_inventory?.Add(new Car("Ford","Focus ST",28.3,26298.98M));
            car_inventory?.Add(new Car("Chevrolet", "Camaro ZL1",19,65401.23M));
            car_inventory?.Add(new Car("Honda", "Accord Sedan EX", 30.2, 26780M));
            car_inventory?.Add(new Car("Lexus", "ES 350", 24.1, 42101.10M));
        }

        public List<Car>? FindCarsByMake(string make)
        {
            if (string.IsNullOrEmpty(make)) return null;
            if (car_inventory != null)
                return car_inventory.Where(x => x.Make.Equals(make, StringComparison.OrdinalIgnoreCase)).ToList();
            else
                return null;
        }

        public Car? FindCarByMakeAndModel(string make, string model)
        {
            if ((!string.IsNullOrWhiteSpace(make)) || (!string.IsNullOrWhiteSpace(model))) return null;
            if (car_inventory != null)
                return car_inventory.First(x => x.Make.Equals(make, StringComparison.OrdinalIgnoreCase) &&
                                                x.Model.Equals(model, StringComparison.OrdinalIgnoreCase));
            else
                return null;
        }

        public Car? PurchaseCar(string make, string model)
        {
            if ((!string.IsNullOrWhiteSpace(make)) || (!string.IsNullOrWhiteSpace(model))) return null;
            var pCar = FindCarByMakeAndModel(make, model);
            if (pCar != null) return null;
            {
                car_inventory?.Remove(pCar);
                return pCar;
            }
        }

        public void AddCar(string make, string model, double mpg, decimal price)
        {
            var aCar = new Car(make, model, mpg, price);
            car_inventory?.Add(aCar);
        }

        public decimal GetTotalCostsOfPurchase(Car car)
        {
            if (car == null) return 0;
            decimal totalCosts = (car.Price + (car.Price * (decimal)TaxRate));
            return totalCosts;
        }

        public Car? FindLeastExpensiveCar()
        {
            if (car_inventory != null) return null;
            {
                Car cCar = car_inventory[0];
                foreach (var car in car_inventory)
                {
                    if (car.Price < cCar.Price)
                    {
                        cCar = car;
                    }
                }
                return cCar;
            }
        }

        public Car? FindMostExpensiveCar()
        {
            if (car_inventory != null) return null;
            {
                Car cCar = car_inventory.First();
                foreach (var car in car_inventory)
                {
                    if (car.Price > cCar.Price)
                    {
                        cCar = car;
                    }
                }
                return cCar;
            }
        }

        public Car? FindBestMPGCar()
        {
            if (car_inventory != null) return null;
            {
                Car cCar = car_inventory[0];
                foreach (var car in car_inventory)
                {
                    if (car.Mpg > cCar.Mpg)
                    {
                        cCar = car;
                    }
                }
                return cCar;
            }
        }

        public Car? FindWorstMPGCar()
        {
            if (car_inventory != null) return null;
            {
                Car cCar = car_inventory[0];
                foreach (var car in car_inventory)
                {
                    if (car.Mpg < cCar.Mpg)
                    {
                        cCar = car;
                    }
                }
                return cCar;
            }
        }

        public int Count => car_inventory.Count;
        public List<Car> Inventory => car_inventory;

    }
}

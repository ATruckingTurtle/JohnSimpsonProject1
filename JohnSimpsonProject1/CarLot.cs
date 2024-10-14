using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JohnSimpsonProject1
{
    public class CarLot
    {
        public const double TaxRate = .078; //constant tax rate

        private readonly List<Car>? _carInventory;

        public CarLot()
        {
            _carInventory = new List<Car>();
            StockLotWithDefaultInventory();
        }

        private void StockLotWithDefaultInventory()
        {
            _carInventory?.Add(new Car("Ford","Focus ST",28.3,26298.98M));
            _carInventory?.Add(new Car("Chevrolet", "Camaro ZL1",19,65401.23M));
            _carInventory?.Add(new Car("Honda", "Accord Sedan EX", 30.2, 26780M));
            _carInventory?.Add(new Car("Lexus", "ES 350", 24.1, 42101.10M));
        }

        public List<Car>? FindCarsByMake(string make)
        {
            if (string.IsNullOrEmpty(make)) return null;
            if (_carInventory != null)
                return _carInventory.Where(x => x.Make.Equals(make, StringComparison.OrdinalIgnoreCase)).ToList();
            else
                return null;
        }

        public Car? FindCarByMakeAndModel(string make, string model)
        {
            if ((!string.IsNullOrWhiteSpace(make)) || (!string.IsNullOrWhiteSpace(model))) return null;
            if (_carInventory != null)
                return _carInventory.First(x => x.Make.Equals(make, StringComparison.OrdinalIgnoreCase) &&
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
                if (pCar != null)
                {
                    _carInventory?.Remove(pCar);
                    return pCar;
                }
            }
            return null;
        }

        public void AddCar(string make, string model, double mpg, decimal price)
        {
            var aCar = new Car(make, model, mpg, price);
            _carInventory?.Add(aCar);
        }

        public List<Car>? GetInventory()
        {
            return _carInventory;
        }

        public static decimal GetTotalCostsOfPurchase(Car car)
        {
            if (car == null) return 0;
            decimal totalCosts = (car.Price + (car.Price * (decimal)TaxRate));
            return totalCosts;
        }

        public Car? FindLeastExpensiveCar()
        {
            if (_carInventory != null) return null;
            {
                var cCar = _carInventory![0];
                foreach (var car in _carInventory)
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
            if (_carInventory != null) return null;
            {
                Car cCar = _carInventory!.First();
                foreach (var car in _carInventory!)
                {
                    if (car.Price > cCar.Price)
                    {
                        cCar = car;
                    }
                }
                return cCar;
            }
        }

        public Car? FindBestMpgCar()
        {
            if (_carInventory != null) return null;
            {
                Car cCar = _carInventory![0];
                foreach (var car in _carInventory)
                {
                    if (car.Mpg > cCar.Mpg)
                    {
                        cCar = car;
                    }
                }
                return cCar;
            }
        }

        public Car? FindWorstMpgCar()
        {
            if (_carInventory != null) return null;
            {
                Car cCar = _carInventory![0];
                foreach (var car in _carInventory)
                {
                    if (car.Mpg < cCar.Mpg)
                    {
                        cCar = car;
                    }
                }
                return cCar;
            }
        }

        public int Count => _carInventory!.Count;
        public List<Car> Inventory => _carInventory!;

        public void AddCar(Car frmNewCar)
        {
            //var bCar = new Car(make, model, mpg, price);
            _carInventory?.Add(frmNewCar);
        }
    }
}

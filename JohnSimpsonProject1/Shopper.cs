using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnSimpsonProject1
{
    public class Shopper
    {
        public string Name { get; set; }
        public decimal MoneyAvailable { get; set; }

        public List<Car> Cars;
        

        public Shopper(string name, decimal moneyAvailable)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (moneyAvailable < 0)
            {
                throw new ArgumentException("Money cannot be less than zero");
            }
            Name = name;
            MoneyAvailable = moneyAvailable;
            Cars = new List<Car>();
        }

        public Boolean CanPurchase(Car car)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car));
            }

            var vehicleCost = CarLot.GetTotalCostsOfPurchase(car);
            return vehicleCost <= MoneyAvailable;
        }

        public void PurchaseCar(Car car)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car));
            }

            if (CanPurchase(car))
            {
                decimal vehicleCost = CarLot.GetTotalCostsOfPurchase(car);
                MoneyAvailable -= vehicleCost;
                Cars.Add(car);
            }
            else
            {
                throw new ArgumentException("Not enough money to purchase");
            }
        }
    }
}

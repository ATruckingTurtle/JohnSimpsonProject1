using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnSimpsonProject1
{
    public class Shopper
    {
        private string Name { get; set; }
        private decimal MoneyAvailable { get; set; }

        private List<Car> Cars;

        public Shopper(string name, decimal moneyAvailable)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Name cannot be null or white space");
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
                throw new ArgumentException("Car cannot be null");
            }

            var vehicleCost = CarLot.GetTotalCostsOfPurchase(car);
            return vehicleCost <= MoneyAvailable;
        }
    }
}

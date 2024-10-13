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

        public List<Car> FindCarsByMake(string make)
        {
            try
            {
                return car_inventory.Where(x => x.Make.Equals(make, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            catch
            {
                return null;
            }

        }
    }
}

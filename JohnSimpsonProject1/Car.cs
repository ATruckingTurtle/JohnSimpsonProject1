using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnSimpsonProject1
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mpg { get; set; }
        public decimal Price { get; set; }

        public Car(string make, string model, double mpg, decimal price)
        {
            if (string.IsNullOrWhiteSpace(make))
            {
                throw new ArgumentNullException(nameof(make));
            }

            if (string.IsNullOrWhiteSpace(model))
            {
                throw new ArgumentException("Model cannot be null or just whitespace!");
            }

            if (mpg <= 0)
            {
                throw new ArgumentException("Miles Per Gallon cannot be less than zero!");
            }

            if (price <= 0)
            {
                throw new ArgumentException("Price must be greater than zero!");
            }

            Make = make;
            Model = model;
            Mpg = mpg;
            Price = price;
        }
    }
}

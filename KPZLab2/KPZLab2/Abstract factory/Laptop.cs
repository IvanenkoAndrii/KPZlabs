using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZLab2.Abstract_factory
{
    public class Laptop : IDevice
    {
        private readonly string _brand;
        public Laptop(string brand)
        {
            _brand = brand;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{_brand} Laptop");
        }
    }
}

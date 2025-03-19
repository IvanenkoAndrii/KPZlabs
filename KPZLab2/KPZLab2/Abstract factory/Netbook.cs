using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZLab2.Abstract_factory
{
    public class Netbook : IDevice
    {
        private readonly string _brand;
        public Netbook(string brand)
        {
            _brand = brand;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{_brand} Netbook");
        }
    }
}

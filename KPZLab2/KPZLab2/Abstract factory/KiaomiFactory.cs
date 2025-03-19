using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZLab2.Abstract_factory
{
    public class KiaomiFactory : IDeviceFactory
    {
        public IDevice CreateLaptop() => new Laptop("Kiaomi");
        public IDevice CreateNetbook() => new Netbook("Kiaomi");
        public IDevice CreateEBook() => new EBook("Kiaomi");
        public IDevice CreateSmartphone() => new Smartphone("Kiaomi");
    }
}

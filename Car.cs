using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PB503_Upcasting_Downcasting_Enum__Exception
{
    public class Car
    {
        static int _id;

        public static int Id => _id;
        public string Brand;
        public string Model;
        public CarTypeEnum Type;
        
        private string ShowInfo()
        {
            string message = $"Id={Id}\nBrand:{Brand}\nModel:{Model}\nType:{Type}\n";
            return message;

        }
        public override string ToString()
        {
            return ShowInfo();
        }
        
        public Car()
        {
            _id++;
        }
        
    }
}

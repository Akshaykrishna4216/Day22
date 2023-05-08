using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpLinq
{
    public class Emp
    {
        private string _name;
        public string Name { get { return _name; } set { value = _name; } }

        private string _city;
        public string City { get { return _city; } set { value = _city; } }
        public Emp() { }
        public Emp(string name, string city)
        {
            _name = name;
            _city = city;
        }

    }
}

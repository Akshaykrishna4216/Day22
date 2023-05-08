using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EmpLinq
{
   public class program
    { 
        static void Main(string[] args)
        {
            List<Emp> list = new List<Emp>();
            list.Add(new Emp("akshay", "kerala"));
            list.Add(new Emp("abi", "karnataka"));
            list.Add(new Emp("anu", "tamil nadu"));
            list.Add(new Emp("ram", "hyderabad"));
            list.Add(new Emp("yadu", "mumbai"));
            list.Add(new Emp("ajay", "mumbai"));
            var empquery =
                from Emp emp in list
                orderby emp.City
                group emp by emp.City;

            foreach (var f in empquery)
            {
                Console.WriteLine("employees with " + f.Key + " city");

                foreach (var e in f)
                {
                    Console.WriteLine(" "+e.Name);
                }
            }


        }
    }
}


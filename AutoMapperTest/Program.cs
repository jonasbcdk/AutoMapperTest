using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Init
            AutoMapper.Mapper.Initialize(config => config.CreateMap<ComplexPerson, SimplePerson>());
            
            var complex = new ComplexPerson();
            complex.FirstName = "Peter";
            complex.LastName = "Larsen";
            complex.City = "Aalborg";

            var simple = AutoMapper.Mapper.Map<SimplePerson>(complex);

            Console.WriteLine(simple.FirstName);

            Console.ReadLine();
        }

        public class ComplexPerson
        {
            public string FirstName;
            public string LastName;
            public string Address;
            public string PostalCode;
            public string City;
        }

        public class SimplePerson
        {
            public string FirstName;
            public string LastName;
        }

    }
}

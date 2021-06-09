using System;
using System.Collections.Generic;
using System.Linq;

namespace AirWaves
{
    class Program
    {
        static void Main(string[] args)
        {
            var company = new Company();
            company.AddPerson(new Person { Age = 20, Name = "John" });
            company.AddPerson(new Person { Age = 25, Name = "Jane" });
            for(int i =0; i < company.Count(); i++)
            {
                Console.WriteLine(company.At(i).Name);
            }
            Console.WriteLine(company.Count());
            company.IncreaseAllAges(10);
            Console.WriteLine(company.At(1).Age);
            Console.ReadLine();
        }
    }
}

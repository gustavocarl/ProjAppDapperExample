using ProjAppDapperExample.Model;
using ProjAppDapperExample.Services;
using System;

namespace ProjAppDapperExample
{
    public class Program
    {
        static void Main(string[] args)
        {

            Airports airport = new Airports()
            {
                City = "Matão",
                Code = "MAT",
                Continent = "Am. Sul",
                Country = "Brasil"
            };

            new AirportServices().Add(airport);

            foreach (var item in new AirportServices().GetAll())
            {
                Console.WriteLine(item);
            }

        }
    }
}

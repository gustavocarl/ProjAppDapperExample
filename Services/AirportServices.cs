using ProjAppDapperExample.Model;
using ProjAppDapperExample.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAppDapperExample.Services
{
    public class AirportServices
    {
        private IAirportRepository _airportRepository;

        public AirportServices()
        {
            _airportRepository = new AirportRepository();

        }

        public bool Add(Airports airport)
        {
            return _airportRepository.Add(airport);
        }

        public List<Airports> GetAll()
        {
            return _airportRepository.GetAll();
        }

    }
}

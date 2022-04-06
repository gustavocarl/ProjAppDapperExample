using Dapper;
using ProjAppDapperExample.Config;
using ProjAppDapperExample.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAppDapperExample.Repository
{
    public class AirportRepository : IAirportRepository
    {
        private string _conn;

        public AirportRepository()
        {
            _conn = DataBaseConfiguration.Get();
        }

        public bool Add(Airports airport)
        {
            bool status = false;

            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                db.Execute(Airports.INSERT, airport);
                status = true;
            }

            return status;
        }

        public List<Airports> GetAll()
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var airports = db.Query<Airports>(Airports.GETALL);
                return (List<Airports>)airports;
            }
        }
    }
}

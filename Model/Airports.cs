using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAppDapperExample.Model
{
    public class Airports
    {
        #region Constants

        public readonly static string INSERT = "INSERT INTO AIRPORT ( " +
            "CITY, COUNTRY, CODE, CONTINENT " +
            ") VALUES ( " +
            "@CITY, @COUNTRY, @CODE, @CONTINENT " +
            ") ";

        public readonly static string GETALL = "SELECT " +
            "ID, CITY, COUNTRY, CODE, CONTINENT " +
            "FROM AIRPORTS ";

        #endregion

        #region Propriedades

        public int Id { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string Code { get; set; }

        public string Continent { get; set; }

        #endregion

        #region Method

        public override string ToString()
        {
            return "ID: " + Id +
                "\nCity: " + City +
                "\nCounty: " + Country +
                "\nCode: " + Code +
                "\nContinent: " + Continent;
        }

        #endregion
    }
}

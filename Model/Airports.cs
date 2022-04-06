using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAppDapperExample.Model
{
    public class Airports
    {
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

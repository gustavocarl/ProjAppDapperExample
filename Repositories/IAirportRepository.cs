using ProjAppDapperExample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAppDapperExample.Repository
{
    public interface IAirportRepository
    {
        bool Add(Airports airport);
        
        List<Airports> GetAll();
    }
}

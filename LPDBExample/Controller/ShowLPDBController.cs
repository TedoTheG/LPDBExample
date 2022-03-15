using LPDBExample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPDBExample.Controller
{
    class ShowLPDBController 
    {
        public List<EloTable> GetAll()
        {
            using (LPDBEntities ex = new LPDBEntities())
            {
                return ex.EloTables.ToList();
            }
        }
    }
}

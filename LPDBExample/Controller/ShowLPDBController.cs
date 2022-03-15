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
        public void CreateRank(EloTable eloTable)
        {
            using (LPDBEntities db = new LPDBEntities())
            {
                var lastRank = db.EloTables.ToList().LastOrDefault();
                if (lastRank == null)
                {
                    lastRank = new EloTable();
                    lastRank.Id = 0;
                }
                eloTable.Id = lastRank.Id + 1;
                db.EloTables.Add(eloTable);
                db.SaveChanges();
            }
        }
    }
}

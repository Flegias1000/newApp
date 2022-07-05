using NewApp.Entities;
using System.Collections.Generic;
using System.Linq;

namespace NewApp.DB
{
    public class Repository
    {
        private DBContext DBContext;

        public Repository(DBContext DBContext)
        {
            this.DBContext = DBContext;
        }
        public List<Persons> GetPrenotazioni()
        {
            //select * from prenotazione
            List<Persons> result = this.DBContext.Persons.ToList();  //nome della tebella

            return result;
        }
    }
}

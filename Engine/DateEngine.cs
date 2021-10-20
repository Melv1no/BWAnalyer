using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomDuLogiciel
{
    class DateEngine
    {
        private List<double> timestamp;
        public DateEngine(List<double> timestamp)
        {
            this.timestamp = timestamp;
        }
        public List<DateTime> date = new List<DateTime>();

        public List<DateTime> getDateTime()
        {
            foreach(double time in timestamp)
            {
                DateTime fecha = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).AddSeconds(time);
                date.Add(fecha);
            }
            return date;
        }
 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alcocalendar.Model
{
    internal class SelectDay
    {   
        public DateTime date {  get; set; }
        public List<SelectAlcoModel> alcolist { get; set; }
        
        public SelectDay(DateTime date)
        {
            this.date = date;
        }

    }
}

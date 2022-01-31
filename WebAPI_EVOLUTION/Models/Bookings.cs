using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_EVOLUTION.Models
{
    public class Bookings
    {
        public int Id { set; get; }

        public virtual Books BookId { get; set; }

        public virtual Students StudentId { get; set; }

        public DateTime DateOut { set; get; }

        public DateTime DateIn { set; get; }

        public string State { set; get; }
    }
}

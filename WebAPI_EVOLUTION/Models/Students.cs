using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_EVOLUTION.Models
{
    public class Students
    {
        public int Id { set; get; }

        public string Name { set; get; }

        public string Doc { set; get; }

        public string Grade { set; get; }

        public string Email { set; get; }

        public DateTime CreationDate { set; get; }

    }
}

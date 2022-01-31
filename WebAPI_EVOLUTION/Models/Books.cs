using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_EVOLUTION.Models
{
    public class Books
    {
        public int Id { set; get; }

        public string Title { set; get; }

        public string Author { set; get; }

        public int Pages { set; get; }
    }
}

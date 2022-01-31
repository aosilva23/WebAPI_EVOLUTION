using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI_EVOLUTION.Models;

namespace WebAPI_EVOLUTION.Data
{
    public class WebAPI_EVOLUTIONContext : DbContext
    {
        public WebAPI_EVOLUTIONContext (DbContextOptions<WebAPI_EVOLUTIONContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPI_EVOLUTION.Models.Books> Books { get; set; }

        public DbSet<WebAPI_EVOLUTION.Models.Students> Students { get; set; }

        public DbSet<WebAPI_EVOLUTION.Models.Bookings> Bookings { get; set; }
    }
}

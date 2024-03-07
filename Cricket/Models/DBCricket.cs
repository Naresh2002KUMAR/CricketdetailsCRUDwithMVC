using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cricket.Models
{
    public class DBCricket:DbContext
    {
        public DBCricket(DbContextOptions<DBCricket> options) : base(options)
        {

        }
        public DbSet<Cricketer> CricketerDetail { get; set; }
    }
}

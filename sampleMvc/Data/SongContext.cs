using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using sampleMvc.Models;

namespace sampleMvc.Data
{
    public class SongContext : DbContext
    {
        public SongContext (DbContextOptions<SongContext> options) : base(options)  
        {
        }

        public DbSet<Song> Songs { get; set; }

        public DbSet<Customer> Customers { get; set; }
    }


}

    
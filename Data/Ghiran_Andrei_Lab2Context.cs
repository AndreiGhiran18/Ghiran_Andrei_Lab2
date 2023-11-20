using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ghiran_Andrei_Lab2.Models;

namespace Ghiran_Andrei_Lab2.Data
{
    public class Ghiran_Andrei_Lab2Context : DbContext
    {
        public Ghiran_Andrei_Lab2Context (DbContextOptions<Ghiran_Andrei_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Ghiran_Andrei_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Ghiran_Andrei_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Ghiran_Andrei_Lab2.Models.Author>? Author { get; set; }
    }
}

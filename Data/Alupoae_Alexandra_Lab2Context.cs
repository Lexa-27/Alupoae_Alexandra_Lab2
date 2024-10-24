using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Alupoae_Alexandra_Lab2.Models;

namespace Alupoae_Alexandra_Lab2.Data
{
    public class Alupoae_Alexandra_Lab2Context : DbContext
    {
        public Alupoae_Alexandra_Lab2Context (DbContextOptions<Alupoae_Alexandra_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Alupoae_Alexandra_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Alupoae_Alexandra_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Alupoae_Alexandra_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Alupoae_Alexandra_Lab2.Models.Category> Category { get; set; } = default!;
    }
}

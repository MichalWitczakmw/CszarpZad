using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using Wpfkol8.Models;

namespace Wpfkol8.Data
{
    public class EdukacjaContext : DbContext
    {
        public EdukacjaContext() : base("EdukacjaConnection")
        {
        }

        public DbSet<Kurs> Kursy { get; set; }
    }
}
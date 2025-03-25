using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using L01P022022GO650.Models;

namespace L01P022022GO650.Models
{
    public class db_notasContext : DbContext
    {
        public db_notasContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<L01P022022GO650.Models.departamentos> departamentos { get; set; } = default!;
        public DbSet<L01P022022GO650.Models.facultades> facultades { get; set; } = default!;
        public DbSet<L01P022022GO650.Models.alumnos> alumnos { get; set; } = default!;
        public DbSet<L01P022022GO650.Models.materias> materias { get; set; } = default!;
    }
}

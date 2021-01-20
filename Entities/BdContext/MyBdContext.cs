
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace ApiMiTesisUG.Entities.MyBdContext
{
    public class MyBdContext : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        public MyBdContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }
        
    }
}
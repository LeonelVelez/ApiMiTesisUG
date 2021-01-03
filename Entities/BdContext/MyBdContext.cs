
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace ApiMiTesisUG.Entities.MyBdContext
{
    public class MyBdContext : DbContext
    {
        public MyBdContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }
    }
}
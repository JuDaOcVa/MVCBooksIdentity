using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Prj_JDOV_BooksIdentityCoreMVCApp.Data
{
    public class ApplicationSecondDbContext : DbContext
    {
        public ApplicationSecondDbContext(DbContextOptions<ApplicationSecondDbContext> options)
             : base(options)
        {
        }
        public DbSet<Models.Libros> Libros { get; set; }
    }
}
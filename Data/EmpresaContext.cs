using Microsoft.EntityFrameworkCore;
using EmpresaAPI.Models;

namespace EmpresaAPI.Data
{
    public class EmpresaContext : DbContext
    {
        public EmpresaContext(DbContextOptions<EmpresaContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
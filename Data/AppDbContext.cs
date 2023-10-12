using Microsoft.EntityFrameworkCore;
using RelatorioAPI.Models;

namespace RelatorioAPI.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<IbgeModel> relatorioAPIs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => 
        options.UseSqlServer("Server=Zuk;Database=Relatorio;Integrated Security=SSPI;TrustServerCertificate=True");
    }
}
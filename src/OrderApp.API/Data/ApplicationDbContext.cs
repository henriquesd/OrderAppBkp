using Microsoft.EntityFrameworkCore;
using OrderApp.Domain.Models;

namespace OrderApp.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}

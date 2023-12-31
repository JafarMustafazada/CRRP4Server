using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CRRP4Server.DAL.Contexts;

public class CRRP4DbContext : IdentityDbContext
{


    public CRRP4DbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<> MyProperty { get; set; }

}

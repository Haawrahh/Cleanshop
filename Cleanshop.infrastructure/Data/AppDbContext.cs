using Cleanshop.domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Cleanshop.infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products => Set<Product>();

    public DbSet<Category> Categories => Set<Category>();
}
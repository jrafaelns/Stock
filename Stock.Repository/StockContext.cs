using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Stock.Data;

namespace Stock.Repository
{
    class StockContext : DbContext
    {

        public StockContext(DbContextOptions<StockContext> options) : base(options)
        {

        }

        public DbSet<Acao> Acoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Acao>().ToTable("Acao");
            
                                    
        }
    }
}

using CustomsDeclaration.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomsDeclaration.Contexts
{
    public class IpsDBContext : DbContext
    {

        public IpsDBContext()
        {
        }

        public IpsDBContext(DbContextOptions<IpsDBContext> options) : base(options)
        {
        }
        public DbSet<LmailitmsRequest> lmailitmsRequest { get; set; }


       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}

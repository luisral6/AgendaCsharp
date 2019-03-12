using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AgendaMVC.Models
{
    public class AgendaMVCContext : DbContext
    {
        public AgendaMVCContext(DbContextOptions<AgendaMVCContext> options) : base(options)
        {
        }

        public DbSet<AgendaMVC.Models.Contacto> Contacto { get; set; }
    }
}

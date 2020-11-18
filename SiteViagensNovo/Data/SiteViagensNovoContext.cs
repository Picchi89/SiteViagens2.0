using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SiteViagensNovo.Models;

namespace SiteViagensNovo.Data
{
    public class SiteViagensNovoContext : DbContext
    {
        public SiteViagensNovoContext (DbContextOptions<SiteViagensNovoContext> options)
            : base(options)
        {
        }

        public DbSet<SiteViagensNovo.Models.Department> Department { get; set; }
    }
}

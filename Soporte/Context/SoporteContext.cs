using Soporte.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Soporte.Context
{
    public class SoporteContext:DbContext
    {
        public SoporteContext()
            : base("DefaultConnection")
        {
        }
        public DbSet<Cliente> Cliente { get; set; }

        public System.Data.Entity.DbSet<Soporte.Models.Categoria> Categorias { get; set; }
    }
    }
 
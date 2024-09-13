using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiOldConsoles.Models;

namespace ApiOldConsoles.Data
{
    public class OldConContext : DbContext
    {
        public OldConContext (DbContextOptions<OldConContext> options)
            : base(options)
        {
        }

        public DbSet<ApiOldConsoles.Models.OldConsole> OldConsole { get; set; } = default!;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ET.Models;

namespace ET.Data
{
    public class ETContext : DbContext
    {
        public ETContext (DbContextOptions<ETContext> options)
            : base(options)
        {
        }

        public DbSet<ET.Models.expense> expense { get; set; } = default!;
        public DbSet<ET.Models.ContactMessage> ContactMessage { get; set; } = default!;
    }
}

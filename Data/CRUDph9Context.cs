using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUDph9.Models;

namespace CRUDph9.Data
{
    public class CRUDph9Context : DbContext
    {
        public CRUDph9Context (DbContextOptions<CRUDph9Context> options)
            : base(options)
        {
        }

        public DbSet<CRUDph9.Models.Studentcs> Studentcs { get; set; } = default!;
    }
}

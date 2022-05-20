using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using practical_26.Models;

namespace practical_26.Data
{
    public class practical_26Context : DbContext
    {
        public practical_26Context (DbContextOptions<practical_26Context> options)
            : base(options)
        {
        }

        public DbSet<practical_26.Models.StudentDetail>? StudentDetail { get; set; }
    }
}

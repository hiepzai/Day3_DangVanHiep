using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Day3_DangVanHiep.Models;

namespace Day3_DangVanHiep.Data
{
    public class Day3_DangVanHiepContext : DbContext
    {
        public Day3_DangVanHiepContext (DbContextOptions<Day3_DangVanHiepContext> options)
            : base(options)
        {
        }

        public DbSet<Day3_DangVanHiep.Models.Category> Category { get; set; } = default!;
    }
}

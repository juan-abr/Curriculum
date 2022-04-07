using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Curriculum.Models;

namespace Curriculum.Data
{
    public class CurriculumContext : DbContext
    {
        public CurriculumContext (DbContextOptions<CurriculumContext> options)
            : base(options)
        {
        }

        public DbSet<Curriculum.Models.Syllabus> Syllabus { get; set; }
    }
}
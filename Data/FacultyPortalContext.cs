using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GECPATAN_FACULTY_PORTAL.Models;

    public class FacultyPortalContext : DbContext
    {
        public FacultyPortalContext (DbContextOptions<FacultyPortalContext> options)
            : base(options)
        {
        }

        public DbSet<GECPATAN_FACULTY_PORTAL.Models.CampusCommittee> CampusCommittee { get; set; } = default!;
    }

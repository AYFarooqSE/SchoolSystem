using Microsoft.EntityFrameworkCore;
using SchoolSystem.Models;

namespace SchoolSystem.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opt):base(opt)
        {
        
        }

        // Table Names
        public DbSet<TeachersModel> Tbl_TeachersBio { get; set; }
    }
}

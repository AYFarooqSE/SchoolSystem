using Microsoft.EntityFrameworkCore;
using SchoolSystem.Models;
using SchoolSystem.Models.StudentModels;

namespace SchoolSystem.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opt):base(opt)
        {
        
        }

        // Table Names
        public DbSet<TeachersModel> Tbl_TeachersBio { get; set; }
        public DbSet<StudentModel> StudentBio { get; set; }
    }
}

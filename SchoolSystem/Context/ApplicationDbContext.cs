using Microsoft.EntityFrameworkCore;

namespace SchoolSystem.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opt):base(opt)
        {
        
        }

        // Table Names
        public int MyProperty { get; set; }
    }
}

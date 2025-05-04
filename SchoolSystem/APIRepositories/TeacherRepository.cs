using Microsoft.AspNetCore.Http.HttpResults;
using SchoolSystem.APIServices;
using SchoolSystem.Data;
using SchoolSystem.Models;

namespace SchoolSystem.APIRepositories
{
    public class TeacherRepository : ITeacherService
    {
        private ApplicationDbContext _context;
        public TeacherRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddTeacherInfo(TeachersModel model)
        {
            _context.Tbl_TeachersBio.Add(model);
            _context.SaveChanges();
        }

        public List<TeachersModel> GetAll()
        {
            List<TeachersModel> liteacher = new List<TeachersModel>();
            
            liteacher=_context.Tbl_TeachersBio.ToList();
            if(liteacher==null)
            {
                
            }

            return liteacher;
        }
    }
}

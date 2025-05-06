using Microsoft.EntityFrameworkCore;
using SchoolSystem.APIServices.V2;
using SchoolSystem.Data;
using SchoolSystem.Models;

namespace SchoolSystem.APIRepositories.V2
{
    public class TeacherRepositoryv2 : ITeacherServicev2
    {
        private ApplicationDbContext _context;
        public TeacherRepositoryv2(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<TeachersModel>> GetAll()
        {
            List<TeachersModel> model = new List<TeachersModel>();
            model= await _context.Tbl_TeachersBio.ToListAsync();
            return model;
        }

        public async Task<TeachersModel> GetByID(int? ID)
        {
            TeachersModel model = new TeachersModel();
            model = await _context.Tbl_TeachersBio.Where(x => x.ID == ID).FirstOrDefaultAsync();
            return model;
        }
    }
}

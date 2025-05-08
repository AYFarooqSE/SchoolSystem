using Microsoft.AspNetCore.Http.HttpResults;
using SchoolSystem.APIServices;
using SchoolSystem.Data;
using SchoolSystem.Interfaces;
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

        public int DeleteRecord(TeachersModel model)
        {
            int Retstatus = 0;
            if(model!=null)
            {
                _context.Tbl_TeachersBio.Remove(model);
                _context.SaveChanges();
                Retstatus = 1;
            }
            return Retstatus;
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

        public TeachersModel GetByID(int? ID)
        {
            TeachersModel liteacher = new TeachersModel();

            liteacher = _context.Tbl_TeachersBio.Where(x=>x.ID==ID).FirstOrDefault();
            if (liteacher == null)
            {

            }

            return liteacher;
        }
    }
}

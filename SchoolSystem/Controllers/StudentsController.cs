using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Interfaces;
using SchoolSystem.Requests;
using System.Threading.Tasks;

namespace SchoolSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController(IStudentService studentService) : ControllerBase
    {
        [HttpPost("add")]
        public async Task<bool> AddStudent(AddStudentRequest addStudentRequest)
        {
         bool response=await studentService.AddStudent(addStudentRequest);
            return true;
        }
    }
}

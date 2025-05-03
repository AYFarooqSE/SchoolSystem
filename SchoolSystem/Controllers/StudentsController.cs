using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Requests;

namespace SchoolSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpPost("add")]
        public bool AddStudent(AddStudentRequest addStudentRequest)
        {
            return true;
        }
    }
}

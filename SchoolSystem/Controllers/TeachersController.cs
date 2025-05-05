using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.APIServices;
using SchoolSystem.Models;

namespace SchoolSystem.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private ITeacherService _repo;
        public TeachersController(ITeacherService repo)
        {
            _repo = repo;
        }

        [HttpGet("GetTeachersBio")]
        public IActionResult GetAll()
        {
            var model = _repo.GetAll();

            return Ok(model);
        }

        [HttpPost]
        public IActionResult CreateNew([FromBody] TeachersModel model)
        {
            if (model != null)
            {
                _repo.AddTeacherInfo(model);
            }

            return Ok(model);
        }

        [HttpGet]
        public IActionResult GetByID(int? ID)
        {
            var model = _repo.GetByID(ID);

            return Ok(model);
        }

        [HttpDelete("{ID}")]
        public IActionResult DeleteRecord(int? ID)
        {
            var modelToDelete = _repo.GetByID(ID);
            if(modelToDelete!=null)
            {
                _repo.DeleteRecord(modelToDelete);
            }
            return Ok(modelToDelete);
        }
    }
}

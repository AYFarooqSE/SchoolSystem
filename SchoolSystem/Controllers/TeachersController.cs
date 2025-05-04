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

        [HttpGet]
        public IActionResult GetAll()
        {
            var model=_repo.GetAll();

            return Ok(model);
        }

        [HttpPost]
        public IActionResult CreateNew([FromBody] TeachersModel model)
        {
            if(model!=null)
            {
                _repo.AddTeacherInfo(model);
            }
                
            return CreatedAtRoute("CreatedID", new {Id=model.ID, model });
        }
    }
}

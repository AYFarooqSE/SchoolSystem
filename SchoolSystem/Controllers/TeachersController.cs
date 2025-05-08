using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.APIServices;
using SchoolSystem.APIServices.V2;
using SchoolSystem.Models;
using SchoolSystem.Validators;

namespace SchoolSystem.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private ITeacherServicev2 _repo;
        public TeachersController(ITeacherServicev2 repo)
        {
            _repo = repo;
        }

        [HttpGet("GetTeachersBio")]
        public async Task<IActionResult> GetAll()
        {
            var model = await _repo.GetAll();

            return Ok(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateNew([FromBody] TeachersModel model)
        {
            TeachersModelValidator validator = new TeachersModelValidator();
            var result= validator.Validate(model);

            if (ModelState.IsValid)
            {
                bool status = false;
                if (model != null)
                {
                    status = await _repo.AddTeacherInfo(model);
                }
                if (status == false)
                {
                    ///
                }
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
        public async Task<IActionResult> DeleteRecord(int? ID)
        {
            bool status = false;
            var modelToDelete = await _repo.GetByID(ID);
            if (modelToDelete != null)
            {
                status = await _repo.DeleteRecord(modelToDelete);
            }
            return Ok(modelToDelete);
        }
    }
}

using Helper.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeacherService.IRepository;
using TeacherService.Models;

namespace TeacherService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        ITeacherRepository _teacherRepository;
        public TeacherController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        [HttpGet]
        [Route("getAll")]
        public IActionResult getAll()
        {
            var Data =  _teacherRepository.GetAll();
            if (Data == null)
                throw new BusinessException("There is no Teachers");
            return Ok(Data);
        }

        [HttpGet]
        [Route("getTeacher/{id}")]
        public IActionResult get(int id)
        {
            var Data = _teacherRepository.Get(id);
            if (Data == null)
                throw new BusinessException($"There is no Teacher with ID = {id} ...");
            return Ok(Data);
        }

        [HttpPost]
        [Route("addTeacher")]
        public IActionResult addStudent([FromBody] Teacher teacher)
        {
            var isExist = _teacherRepository.Get(teacher.Id);
            if (isExist != null)
                throw new BusinessException("This teacher is dublicated...");

            var Data = _teacherRepository.Add(teacher);
            return Ok(Data);
        }
    }
}

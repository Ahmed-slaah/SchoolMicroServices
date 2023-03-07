using Helper.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentService.IRepository;
using StudentService.Models;

namespace StudentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet]
        [Route("getAll")]
        public IActionResult getAll()
        {
            var Data = _studentRepository.GetAll();
            if (Data == null)
                throw new BusinessException("There is no Students yet...");
            return Ok(Data);
        }

        [HttpGet]
        [Route("getStudent/{id}")]
        public IActionResult getStudent(int id)
        {
            var Data = _studentRepository.Get(id);
            if (Data == null)
                throw new BusinessException($"There is no Student with ID = {id} ...");
            return Ok(Data);
        }

        [HttpPost]
        [Route("addStudent")]
        public IActionResult addStudent([FromBody]Student student)
        {
            var isExist = _studentRepository.Get(student.Id);
            if (isExist != null)
                throw new BusinessException("This student is dublicated...");

            var Data = _studentRepository.Add(student);
            return Ok(Data);
        }

    }
}

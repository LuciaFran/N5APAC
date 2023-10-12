using Microsoft.AspNetCore.Mvc;
using PAC.IBusinessLogic;
using PAC.Domain;

namespace PAC.WebAPI.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentLogic _studentLogic;

        public StudentController(IStudentLogic studentLogic)
        {
            _studentLogic = studentLogic;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Student student)
        {
            try
            {
                _studentLogic.InsertStudents(student);
                return Ok(); 
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); 
            }
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            try
            {
                IEnumerable<Student> students = _studentLogic.GetStudents();
                return Ok(students);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetStudentsById(int id)
        {
            try
            {
                Student student = _studentLogic.GetStudentById(id);
                if (student != null)
                {
                    return Ok(student);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult CreateStudent([FromBody] Student student)
        {
            try
            {
                _studentLogic.InsertStudents(student);
                return Ok(student); 
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Db;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public StudentController(ApplicationDbContext db)
        {
            _db = db;
            
        }
       
        [HttpPost]
        [Route("Create")]
        public IActionResult Create([FromBody]Student s1)//crud[frombody]
        {
            _db.Add(s1);
            _db.SaveChanges();
            return Ok(s1);
        }
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            List<Student>students=new List<Student>();
            students=_db.Students.ToList();
            return Ok(students);
        }
        [HttpGet]
        [Route("GetbyId")]
        public IActionResult GetbyId(int id)
        {
            Student s1 = _db.Students.FirstOrDefault(x => x.Id == id);
            return Ok(s1);  
        }
        [HttpPut]
        [Route("update")]
        public IActionResult Update([FromBody] Student s1) 
        {
            _db.Update(s1);
            _db.SaveChanges();
            return Ok(s1);  
        }
        [HttpDelete]
        [Route("Delete")]
        public IActionResult DeleteById(int id)
        {
            Student s1 = _db.Students.FirstOrDefault(x => x.Id == id);
            _db.Remove(s1);
            _db.SaveChanges();
            return Ok(s1);

        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi.Data;
using webapi.Data.DataModel;
using webapi.DataModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly DataContext _context;
        public StudentController(DataContext context)
        {
            _context = context;
        }


        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<StudentTable> Get()
        {
            return _context.StudentTable;
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public StudentTable Get(int id)
        {
            return _context.StudentTable.FirstOrDefault(f =>f.StudentId == id);
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] StudentTable value)
        {
            _context.StudentTable.Add(value);
            _context.SaveChanges();

        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]StudentTable value) 
        {
            var UpdateRecord = _context.StudentTable.FirstOrDefault(f=>f.StudentId == id);

            if (null != UpdateRecord)
            {

                UpdateRecord.StudentFirstName = value.StudentFirstName;
                UpdateRecord.StudentLasttName = value.StudentLasttName;
                UpdateRecord.Gender = value.Gender;
                UpdateRecord.FatherName = value.FatherName;
                UpdateRecord.DOB=value.DOB;
                UpdateRecord.Status= value.Status;

                _context.StudentTable.Update(UpdateRecord);
                _context.SaveChanges();
            
            
            }

      

        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.Database.ExecuteSqlRaw($"DELETE FROM StudenTable WHERE StudentId={id}");
        }
    }
}

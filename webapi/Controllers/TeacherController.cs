using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi.DataModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly TeacherContext _context;

        public TeacherController(TeacherContext context)
        {
            _context = context;
        }


        // GET: api/<TeacherController>
        [HttpGet]
        public IEnumerable<TeacherTable> Get()
        {
            return _context.TeacherTable;
        }

        // GET api/<TeacherController>/5
        [HttpGet("{id}")]
        public TeacherTable Get(int id)
        {
            return _context.TeacherTable.FirstOrDefault(f => f.TeacherId == id);
        }

        // POST api/<TeacherController>
        [HttpPost]
        public void Post([FromBody] TeacherTable value)
        {
            _context.TeacherTable.Add(value);
            _context.SaveChanges();
            
        }

        // PUT api/<TeacherController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TeacherTable value)
        {
            var UpdateRecord = _context.TeacherTable.FirstOrDefault(f => f.TeacherId == id);

            if(null != UpdateRecord)
            {
                UpdateRecord.TeacherName = value.TeacherName;
                UpdateRecord.Address = value.Address;
                UpdateRecord.PhoneNumber = value.PhoneNumber;
                UpdateRecord.Status = value.Status;

                _context.TeacherTable.Update(UpdateRecord);
                _context.SaveChanges();
            }

        }

        // DELETE api/<TeacherController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.Database.ExecuteSqlRaw($"DELETE FROM TeacherTable WHERE TeacherId ={id} ");
        }

    }
}

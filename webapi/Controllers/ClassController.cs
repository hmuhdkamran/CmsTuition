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
    public class ClassController : ControllerBase
    {
        private readonly DataContext _context;
        public ClassController(DataContext context)
        {
            _context = context;
        }

        // GET: api/<ClassController>
        [HttpGet]
        public IEnumerable<ClassTable> Get()
        {
            return _context.classTable;
        }

        // GET api/<ClassController>/5
        [HttpGet("{id}")]
        public ClassTable Get(int id)
        {
            return _context.classTable.FirstOrDefault(f => f.ClassId == id);
        }

        // POST api/<ClassController>
        [HttpPost]
        public void Post([FromBody] ClassTable value)
        {
            _context.classTable.Add(value);
            _context.SaveChanges();
        }

        // PUT api/<ClassController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ClassTable value)
        {
            var UpdateRecord = _context.classTable.FirstOrDefault(f => f.ClassId == id);

            if(null!=UpdateRecord)
            {
                UpdateRecord.ClassName = value.ClassName;
                UpdateRecord.TeacherId=value.TeacherId;
                UpdateRecord.Status=value.Status;

                _context.classTable.Update(UpdateRecord);
                _context.SaveChanges();
            }

        }

        // DELETE api/<ClassController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.Database.ExecuteSqlRaw($"DELETE FROM ClassTable WHERE ClassId = {id}");
        }
    }
}

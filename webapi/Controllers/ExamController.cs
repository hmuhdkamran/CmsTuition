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
    public class ExamController : ControllerBase
    {
        private readonly DataContext _context;

        public ExamController(DataContext context)
        {
            _context = context;
        }


        // GET: api/<ExamController>
        [HttpGet]
        public IEnumerable<ExamTable> Get()
        {
            return _context.ExamTable;
        }

        // GET api/<ExamController>/5
        [HttpGet("{id}")]
        public ExamTable Get(int id)
        {
            return _context.ExamTable.FirstOrDefault(f => f.ExamID == id);
        }

        // POST api/<ExamController>
        [HttpPost]
        public void Post([FromBody] ExamTable value)
        {
            _context.ExamTable.Add(value);
            _context.SaveChanges();
        }

        // PUT api/<ExamController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ExamTable value)
        {
         var UpdateRecord=  _context.ExamTable.FirstOrDefault(f => f.ExamID == id);
          if(null != UpdateRecord)
            {
                UpdateRecord.ExamName = value.ExamName;
                UpdateRecord.SubjectId = value.SubjectId;
                UpdateRecord.ClassId = value.ClassId;
                UpdateRecord.StudentId=value.StudentId;

                _context.ExamTable.Update(UpdateRecord);
                _context.SaveChanges();
               
            }

        }

        // DELETE api/<ExamController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.Database.ExecuteSqlRaw($"DELETE FROM ExamTable WHERE ExamId= {id}");
        }
    }
}

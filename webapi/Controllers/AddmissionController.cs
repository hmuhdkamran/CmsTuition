using Microsoft.AspNetCore.Mvc;
using webapi.DataModel;
using Microsoft.EntityFrameworkCore;
using webapi.Data;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddmissionController : ControllerBase
    {
        private readonly  DataContext _context;
        public AddmissionController(DataContext context)
        {
            _context = context;
        }


        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<AddmissionTable> Get() // show all record
        {
            return _context.AddmissionTable;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public AddmissionTable Get(int id)  // show specific id ya table
        {
            return _context.AddmissionTable.FirstOrDefault(f => f.AddmissionId == id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] AddmissionTable value)
        {
            
            _context.AddmissionTable.Add(value);
            _context.SaveChanges();
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] AddmissionTable value)
        {
            var updateRecord = _context.AddmissionTable.FirstOrDefault(d=>d.AddmissionId == id);
            if (updateRecord != null)
            {
                updateRecord.ClassId = value.ClassId;
                updateRecord.StudentId = value.StudentId;
                updateRecord.FeesId = value.FeesId;
                updateRecord.date = value.date ;

                _context.AddmissionTable.Update(updateRecord);
                _context.SaveChanges();
            }
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.Database.ExecuteSqlRaw($"DELETE FROM AddmissionTable WHERE AddmissionId = {id}");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi.DataModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        private readonly AttendanceContext _context;
        public AttendanceController(AttendanceContext context)
        {
            _context = context;
        }


        // GET: api/<AttendanceController>
        [HttpGet]
        public IEnumerable<AttandanceTable> Get()
        {
            return _context.attandanceTable;
        }

        // GET api/<AttendanceController>/5
        [HttpGet("{id}")]
        public AttandanceTable Get (int id)
        {
          return   _context.attandanceTable.FirstOrDefault(f => f.AttendanceId ==id );
        }

        // POST api/<AttendanceController>
        [HttpPost]
        public void Post([FromBody] AttandanceTable value)
        {
            _context.attandanceTable.Add(value);
            _context.SaveChanges();
        }

        // PUT api/<AttendanceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] AttandanceTable value)
        {
            var UpdateRecord = _context.attandanceTable.FirstOrDefault(f => f.AttendanceId ==id);
            if(null != UpdateRecord) {

                UpdateRecord.AttendanceId = value.AttendanceId;
                UpdateRecord.StudentId = value.StudentId;
                UpdateRecord.Day= value.Day;
                UpdateRecord.Date = value.Date;
                UpdateRecord.Month= value.Month;
                UpdateRecord.Status= value.Status;
                _context.attandanceTable.Update(UpdateRecord);
                _context.SaveChanges();

            }
        }

        // DELETE api/<AttendanceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.Database.ExecuteSqlRaw($"DELETE FROM AttandanceTable WHERE AttandanceId ={id}");
        }
    }
}

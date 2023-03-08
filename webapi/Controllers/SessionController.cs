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
    public class SessionController : ControllerBase
    {
        private readonly DataContext _context;
        public SessionController(DataContext context)
        {
            _context = context;
        }

        // GET: api/<SessionController>
        [HttpGet]
        public IEnumerable<SessionTable> Get()
        {
            return _context.SessionTable;
        }

        // GET api/<SessionController>/5
        [HttpGet("{id}")]
        public SessionTable Get(int id)
        {
            return _context.SessionTable.FirstOrDefault(f => f.SessionId == id);
        }

        // POST api/<SessionController>
        [HttpPost]
        public void Post([FromBody] SessionTable value)
        {
            _context.SessionTable.Add(value);
            _context.SaveChanges();
        }

        // PUT api/<SessionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] SessionTable  value)
        {
            var UpdateRecord = _context.SessionTable.FirstOrDefault(f => f.SessionId == id);

            if(null != UpdateRecord)
            {
                UpdateRecord.StartDate = value.StartDate;
                UpdateRecord.SessionEndDate = value.SessionEndDate;
                UpdateRecord.SessionYear = value.SessionYear;
                UpdateRecord.Status = value.Status;

                _context.SessionTable.Update(UpdateRecord);
                _context.SaveChanges();

              

            }

        }

        // DELETE api/<SessionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.Database.ExecuteSqlRaw($"DELETE FROM SessionTable WHERE SessionId ={id}");
        }
    }
}

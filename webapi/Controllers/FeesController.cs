using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi.DataModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeesController : ControllerBase
    {
        private readonly FeesContext _context;
        public FeesController(FeesContext context)
        {
            _context = context;
        }

        // GET: api/<FeesController>
        [HttpGet]
        public IEnumerable<FeesTable> Get()
        {
            return _context.FeesTable;
        }

        // GET api/<FeesController>/5
        [HttpGet("{id}")]
        public FeesTable Get(int id)
        {
            return _context.FeesTable.FirstOrDefault(f => f.FeesId == id);
        }

        // POST api/<FeesController>
        [HttpPost]
        public void Post([FromBody] FeesTable value)
        {
          _context.FeesTable.Add(value);
            _context.SaveChanges();

        }

        // PUT api/<FeesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] FeesTable value)
        {
            var UpdateRecord = _context.FeesTable.FirstOrDefault(f => f.FeesId == id);

            if(null!= UpdateRecord)
            {
                UpdateRecord.StudentId = value.StudentId;
                UpdateRecord.Month= value.Month;
                UpdateRecord.Year= value.Year;
                UpdateRecord.TotalFee= value.TotalFee;
                UpdateRecord.RecpitNo= value.RecpitNo;
                UpdateRecord.RemaningFee= value.RemaningFee;
                UpdateRecord.Paid = value.Paid;

                _context.FeesTable.Update(UpdateRecord);
                _context.SaveChanges();

            }

        }

        // DELETE api/<FeesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.Database.ExecuteSqlRaw($"DELETE FROM FeesTable WHERE FeesId ={id}");
        }
    }
}

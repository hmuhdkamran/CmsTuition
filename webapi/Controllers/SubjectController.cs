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
    public class SubjectController : ControllerBase
    {
        private readonly DataContext _Context;

        public SubjectController(DataContext Context)
        {
            _Context = Context;
        }
      
        // GET: api/<SubjectController>
        [HttpGet]
        public IEnumerable<SubjectTable> Get()
        {
            return _Context.SubjectTable;
        }

        // GET api/<SubjectController>/5
        [HttpGet("{id}")]
        public SubjectTable Get(int id)
        {
            return _Context.SubjectTable.FirstOrDefault(f => f.SubjectId == id);
        }

        // POST api/<SubjectController>
        [HttpPost]
        public void Post([FromBody] SubjectTable value)
        {
            _Context.SubjectTable.Add(value);
            _Context.SaveChanges();
        }

        // PUT api/<SubjectController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] SubjectTable value)
        {
            var UpdateRecord= _Context.SubjectTable.FirstOrDefault( f => f.SubjectId ==id);
            if(null != UpdateRecord) {

                UpdateRecord.SubjectName=value.SubjectName;
                UpdateRecord.TeacherId = value.TeacherId;

                _Context.SubjectTable.Update(UpdateRecord);
                _Context.SaveChanges();
            
            }
           
        }

        // DELETE api/<SubjectController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _Context.Database.ExecuteSqlRaw($"DELETE FROM SubjectTable WHERE SubjectId ={id}");
        }
    }
}

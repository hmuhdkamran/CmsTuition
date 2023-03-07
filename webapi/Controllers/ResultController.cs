using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi.DataModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultController : ControllerBase
    {
        private readonly ResultContext _Context;

       public ResultController(ResultContext context)
        {
            _Context = context;
        }



        // GET: api/<ResultController>
        [HttpGet]
        public IEnumerable<ResultTable> Get()
        {
            return _Context.ResultTable;
        }

        // GET api/<ResultController>/5
        [HttpGet("{id}")]
        public ResultTable  Get(int id)
        {
            return _Context.ResultTable.FirstOrDefault(f => f.ResultId == id);
        }

        // POST api/<ResultController>
        [HttpPost]
        public void Post([FromBody] ResultTable value)
        {
            _Context.ResultTable.Add(value);
            _Context.SaveChanges();
        }

        // PUT api/<ResultController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ResultTable value)
        {

            var  UpdateRecord= _Context.ResultTable.FirstOrDefault(f => f.ResultId == id);
            if(null != UpdateRecord)
            {
                UpdateRecord.ExamId = value.ExamId;
                UpdateRecord.StudentId = value.StudentId;
                UpdateRecord.Marks = value.Marks;
                UpdateRecord.SubjectId = value.SubjectId;

                _Context.ResultTable.Update(UpdateRecord);
                _Context.SaveChanges();
            }
        }

        // DELETE api/<ResultController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _Context.Database.ExecuteSqlRaw($"DELETE FROM ResultTable WHERE ResultId ={id}");
        }
    }
}

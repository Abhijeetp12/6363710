using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private static readonly List<string> items = new List<string>
        {
            "item1","item2","item3"
        };

        [HttpGet]

        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(items);
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            if (id < 0 || id >= items.Count)
            {
                return NotFound("item not found");
            }
            return Ok(items[id]);
        }

        [HttpPost]
        public ActionResult Post([FromBody] string value)
        {
            items.Add(value);

            return CreatedAtAction(nameof(Get), new { id = items.Count - 1 }, value);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] string newvalue)
        {
            if (id < 0 || id >= items.Count)
            {
                return NotFound("item not found");
            }
            items[id] = newvalue;
            return NoContent();
        }

        [HttpDelete("{id}")]

        public ActionResult Delete(int id)
        {
            if (id < 0 || id >= items.Count)
            {
                return NotFound("item not found");
            }
            items.RemoveAt(id);
            return NoContent();
        }
    }
}

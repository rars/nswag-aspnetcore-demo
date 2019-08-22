using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    /// <summary>
    /// Values Controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// Gets all values.
        /// </summary>
        /// <returns>List of values.</returns>
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Get specific value by id.
        /// </summary>
        /// <param name="id">The id to get the value for.</param>
        /// <returns>The value for the specified id.</returns>
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Submit new value.
        /// </summary>
        /// <param name="value">The new value to submit.</param>
        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        /// Update the value with the specified id to the new value.
        /// </summary>
        /// <param name="id">Identifies the value to update.</param>
        /// <param name="value">The new value to set.</param>
        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        /// Removes the value with the specified id.
        /// </summary>
        /// <param name="id">Identifies the value to remove.</param>
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

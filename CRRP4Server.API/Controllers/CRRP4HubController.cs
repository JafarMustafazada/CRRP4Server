using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRRP4Server.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CRRP4HubController : ControllerBase
{
    // GET: api/<CRRP4HubController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/<CRRP4HubController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<CRRP4HubController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<CRRP4HubController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<CRRP4HubController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}

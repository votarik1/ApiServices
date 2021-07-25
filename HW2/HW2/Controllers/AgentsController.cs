using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgentsController : ControllerBase
    {
        public List<AgentInfo> ListOfAgents { get; set; }
        public AgentsController()
        {
            ListOfAgents = new List<AgentInfo>();
        }

        [HttpGet("GetListOfAgents")]
        public IActionResult GetListOfAgents()
        {
            return Ok(ListOfAgents);
        }
        [HttpPost("register")]
        public IActionResult RegisterAgent([FromBody] AgentInfo agentInfo)
        {
            return Ok();
        }
        [HttpPut("enable/{agentID}")]
        public IActionResult EnableAgentByID([FromRoute] int agentID)
        {
            return Ok();
        }
        [HttpPut("disable/{agentID}")]
        public IActionResult DisableAgentByID([FromRoute] int agentID)
        {
            return Ok();
        }
    }
}

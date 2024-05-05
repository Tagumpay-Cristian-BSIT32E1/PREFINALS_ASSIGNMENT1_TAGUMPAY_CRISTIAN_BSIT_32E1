using Microsoft.AspNetCore.Mvc;
using System;

namespace ProtectedApi
{
    [ApiController]
    [Route("[controller]")]
    public class ValueController : ControllerBase
    {
        private readonly string _owner = "Cristian Tagumpay";
        private readonly Random _random = new Random();
        private readonly string[] _thingsAboutOwner = new[]
        {
            "I sleep a lot."
            "I like watching horror movies alone at night."
            "I'm more than 20 years old."
            "I have dog named Anti Leng."
            "Currently taking BSIT.",
            "I like Fast and Furious Movies."
            "Watch Suits on Netflix. It's fun."
            "I don't drink coffee, it's not for kids."
            "I don't drink soda."
            "This is the 10th."
        };

        [HttpGet("about/me")]
        public IActionResult AboutMe()
        {
            var thing = _thingsAboutOwner[_random.Next(_thingsAboutOwner.Length)];
            return Ok(thing);
        }

        [HttpGet("about")]
        public IActionResult About()
        {
            return Ok(_owner);
        }

        [HttpPost("about")]
        public IActionResult About([FromBody] NameModel model)
        {
            return Ok($"Hi {model.Name} from {_owner}");
        }
    }

    public class NameModel
    {
        public string? Name { get; set; }
    }
}
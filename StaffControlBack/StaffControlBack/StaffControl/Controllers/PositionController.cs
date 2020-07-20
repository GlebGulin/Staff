using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;

namespace StaffControl.Controllers
{
    //[Route("api/[controller]")]
    public class MainController : Controller
    {
        private readonly IPositionService _s;
        public MainController(IPositionService s)
        {
            _s = s;
        }
        [HttpPost]
        [Route("postposition")]
        public IActionResult Post([FromBody]Position model)
        {

            return Ok(
                _s.Add(model));

        }

    }
}

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
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _service;
        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("getemployees")]
        public IActionResult Index()
        {
            return Ok((
                _service.GetEmployees()
                , _service.GetPos()));
        }
        [HttpPost]
        [Route("postemployeen")]
        public IActionResult Post([FromBody]Employee model)
        {

            return Ok(
                _service.Add(model));

        }

    }
}

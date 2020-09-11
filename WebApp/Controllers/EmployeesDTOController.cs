using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesDTOController : ControllerBase
    {
        private readonly IEmployeesDTOLogic _logic;
        public EmployeesDTOController(IEmployeesDTOLogic logic)
        {
            _logic = logic;
        } 

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_logic.GetAllEmployeesDTO());
        }
    }
}

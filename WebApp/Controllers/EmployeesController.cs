using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmpleadoLogic _logic;
        public EmployeesController(IEmpleadoLogic logic)
        {
            _logic = logic;
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            return Ok(_logic.GetById(id));
        }

        [HttpGet]
        [Route("GetEmployees/{id:int}")]
        public IActionResult GetAll(int id)
        {
            return Ok(_logic.GetAllEmpleado(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] Employees empleado)
        {
            if (!ModelState.IsValid) return BadRequest();
            return Ok(_logic.Insert(empleado));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Employees empleado)
        {
            if (ModelState.IsValid && _logic.Update(empleado))
            {
                return Ok(new { Message = "El empleado ha sido Actualizado" });
            }
            return BadRequest();
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] Employees empleado)
        {
            if (empleado.id > 0)
                return Ok(_logic.Delete(empleado));
            return BadRequest();
        }
    }
}


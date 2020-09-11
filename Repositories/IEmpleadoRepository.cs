using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public interface IEmpleadoRepository : IRepository<Employees>
    {
        //Hacer el DTO
        public List<Employees> GetAllEmpleado();

    }
}

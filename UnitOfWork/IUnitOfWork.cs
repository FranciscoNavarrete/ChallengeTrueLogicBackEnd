using Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitOfWork
{
    public interface IUnitOfWork
    {
        IEmpleadoRepository Empleado { get; }
        IEmployeesDTORepository EmployeesDTO { get; }

    }
}

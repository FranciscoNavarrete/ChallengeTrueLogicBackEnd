using Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWork;

namespace DataAccess
{
    public class FabricaUnitOfWork : IUnitOfWork
    {
        public FabricaUnitOfWork(string connectionString)
        {
            
            Empleado = new EmpleadoRepository(connectionString);
            EmployeesDTO = new EmployeesDTORepository(connectionString);

        }
        public IEmpleadoRepository Empleado { get; private set; }

        public IEmployeesDTORepository EmployeesDTO { get; private set; }
    }
}

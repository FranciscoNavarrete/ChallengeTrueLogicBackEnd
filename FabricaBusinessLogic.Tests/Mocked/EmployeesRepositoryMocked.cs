using AutoFixture;
using Models;
using Moq;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitOfWork;

namespace FabricaBusinessLogic.Tests.Mocked
{
    public class EmployeesRepositoryMocked
    {
        private readonly List<Employees> _employess;

        public EmployeesRepositoryMocked()
        {
            _employess = Employees();
        }

        //Retorno la unidad de trabajo mockeado
        public IUnitOfWork GetInstance()
        {
            var mocked = new Mock<IUnitOfWork>();
            mocked.Setup(u => u.Empleado)
                .Returns(GetEmployeesRepositoryMocked());
            return mocked.Object;
        }
        //mockeo el repository con su id
        public IEmpleadoRepository GetEmployeesRepositoryMocked()
        {
            var employeesMocked = new Mock<IEmpleadoRepository>();
            employeesMocked.Setup(c => c.GetAllEmpleado())
                .Returns(_employess);

            return employeesMocked.Object;
        }

        //Mockeo la lista de empleados con 10 id
        private List<Employees> Employees()
        {
            var fixture = new Fixture();
            var employees = fixture.CreateMany<Employees>(10).ToList();
            for (int i = 0; i < 10; i++)
            {
                employees[i].id = (i + 1);
            }
            return employees;
        }
    }
}

using BusinessLogic.Implementations;
using BusinessLogic.Interfaces;
using FabricaBusinessLogic.Tests.Mocked;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWork;
using Xunit;

namespace FabricaBusinessLogic.Tests
{
    public class EmployeesLogicTest
    {

        private readonly IUnitOfWork _unitMocked;
        private readonly IEmpleadoLogic _employeeLogic;
        public EmployeesLogicTest()
        {
            var unitMocked = new EmployeesRepositoryMocked();
            _unitMocked = unitMocked.GetInstance();
            _employeeLogic = new EmpleadoLogic(_unitMocked);
        }
        //xunit, me permite crea unittest
        [Fact]
        public void GetById_Employees_Test()
        {
            List<Models.EmployeesDTO> result = _employeeLogic.GetAllEmpleado(1);
            result.Should().NotBeNull();//el resultado no debe ser nulo
            //result.id.Should().BeGreaterThan(0); //Tiene que se mayor que cero
        }
    }
}

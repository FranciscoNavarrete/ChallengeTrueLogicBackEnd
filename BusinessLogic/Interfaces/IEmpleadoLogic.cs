using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces
{
    public interface IEmpleadoLogic
    {
        Employees GetById(int id);
        IEnumerable<Employees> GetList();
        int Insert(Employees empleado);
        bool Update(Employees empleado);
        bool Delete(Employees empleado);
        List<EmployeesDTO> GetAllEmpleado(int id);
        //IEnumerable<EmpleadoDTO> GetAllEmpleadoDTO();
        //bool DeleteById(int id);
    }
}

using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces
{
    public interface IEmployeesDTOLogic
    {
        EmployeesDTO GetById(int id);
        IEnumerable<EmployeesDTO> GetList();
        int Insert(EmployeesDTO empleado);
        bool Update(EmployeesDTO empleado);
        bool Delete(EmployeesDTO empleado);
        IEnumerable<EmployeesDTO> GetAllEmployeesDTO();
    }
}

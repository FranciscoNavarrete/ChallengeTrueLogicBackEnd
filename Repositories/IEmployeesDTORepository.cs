using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public interface IEmployeesDTORepository: IRepository<EmployeesDTO>
    {
        IEnumerable<EmployeesDTO> GetAllEmployeesDTO();

    }
}

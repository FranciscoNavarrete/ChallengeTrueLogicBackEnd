using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class EmployeesDTORepository : Repository<EmployeesDTO>, IEmployeesDTORepository
    {
        public EmployeesDTORepository(string conecctionString): base (conecctionString)
        {

        }
        public IEnumerable<EmployeesDTO> GetAllEmployeesDTO()
        {
            throw new NotImplementedException();
        }
    }
}

using BusinessLogic.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWork;

namespace BusinessLogic.Implementations
{
    public class EmployeesDTOLogic : IEmployeesDTOLogic
    {
        private readonly IUnitOfWork _unitOfWork;
        public EmployeesDTOLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public bool Delete(EmployeesDTO empleado)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeesDTO> GetAllEmployeesDTO()
        {
            return _unitOfWork.EmployeesDTO.GetAllEmployeesDTO();
        }

        public EmployeesDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeesDTO> GetList()
        {
            throw new NotImplementedException();
        }

        public int Insert(EmployeesDTO empleado)
        {
            throw new NotImplementedException();
        }

        public bool Update(EmployeesDTO empleado)
        {
            throw new NotImplementedException();
        }
    }
}

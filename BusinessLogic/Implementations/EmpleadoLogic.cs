using BusinessLogic.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitOfWork;
public enum ETipoSalario
{
    ForHours = 1,
    Month =2    
}
namespace BusinessLogic.Implementations
{
    public class EmpleadoLogic: IEmpleadoLogic
    {
        private readonly IUnitOfWork _unitOfWork;
        public EmpleadoLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public bool Delete(Employees empleado)
        {
            return _unitOfWork.Empleado.Delete(empleado);
        }

        public List<EmployeesDTO> GetAllEmpleado(int id)
        {//Retornar un DTO

            //List<EmployeesDTO> lst = new List<EmployeesDTO>();

            //EmployeesDTO employees_1 = new EmployeesDTO();
            //employees_1.Id = 0;
            List<Employees> responseEmpleados = new List<Employees>();
            if (id> 0)
            {
                responseEmpleados = _unitOfWork.Empleado.GetAllEmpleado().Where(x => x.id == id).ToList();

            }
            else
            {
                responseEmpleados = _unitOfWork.Empleado.GetAllEmpleado();

            }

            //lst.Add(employees_1);
            //Response<List<Employees>> Aux =_unitOfWork.Empleado.GetAllEmpleado();

            Response<List<EmployeesDTO>> response = new Response<List<EmployeesDTO>>();
                response.Successful = true;
                response.Message = "";
                response.Content = MapperDto(responseEmpleados);
                

            return response.Content;
            
        }

        private List<EmployeesDTO> MapperDto(List<Employees> emp)
        {
            //EmployeesDTO AuxDTO = new EmployeesDTO();
            List<EmployeesDTO> ListempDTO = new List<EmployeesDTO>();
            foreach (var item in emp)
            {
            EmployeesDTO AuxDTO = new EmployeesDTO();
                AuxDTO.id = item.id;
                AuxDTO.name = item.name;
                AuxDTO.contractTypeName = item.contractTypeName;
                AuxDTO.roleId = item.roleId;
                AuxDTO.roleName = item.roleName;
                AuxDTO.roleDescription = item.roleDescription;
                AuxDTO.hourlySalary = item.hourlySalary;
                AuxDTO.monthlySalary = item.monthlySalary;
                AuxDTO.annual = CalcularSalario(item);

                ListempDTO.Add(AuxDTO);
            }
            return ListempDTO;
        }

        private decimal CalcularSalario(Employees emp)
        {
            decimal salario = 0;
            if (emp.contractTypeName == "HourlySalaryEmployee")
            {
                salario = (120 * emp.hourlySalary) / 12;
            }
            else
            {
                if(emp.contractTypeName == "MonthlySalaryEmployee")
                   salario = emp.monthlySalary * 12;
            }
            return salario;


                   
        }
        public Employees GetById(int id)
        {
            return _unitOfWork.Empleado.GetById(id);
        }

        public IEnumerable<Employees> GetList()
        {
            return _unitOfWork.Empleado.GetList();
        }


        public int Insert(Employees empleado)
        {
            Employees em = new Employees();
            em.name = empleado.name;
            em.id = empleado.id;
            em.contractTypeName = empleado.contractTypeName;
            em.roleDescription = empleado.roleDescription;
            em.roleId = empleado.roleId;
            em.roleName = empleado.roleName;
            CalcularHora(empleado);
            em.hourlySalary = empleado.hourlySalary;
            em.monthlySalary = empleado.monthlySalary;
            return _unitOfWork.Empleado.Insert(empleado);
        }

        public bool Update(Employees empleado)
        {
            //Employees em = new Employees();
            //em.Name = empleado.Name;
            //em.Last_Name = empleado.Last_Name;
            //em.Email = empleado.Email;
            //em.Dni = empleado.Dni;
            //em.Contrato = empleado.Contrato;
            //CalcularHora(empleado);
            //em.Salario = empleado.Salario;
            //return _unitOfWork.Empleado.Update(empleado);
            Employees em = new Employees();
            em.name = empleado.name;
            em.id = empleado.id;
            em.contractTypeName = empleado.contractTypeName;
            em.roleDescription = empleado.roleDescription;
            em.roleId = empleado.roleId;
            em.roleName = empleado.roleName;
            CalcularHora(empleado);
            em.hourlySalary = empleado.hourlySalary;
            em.monthlySalary = empleado.monthlySalary;
            return _unitOfWork.Empleado.Update(empleado);
        }
        public static Employees CalcularHora(Employees empleado)
        {
            if(empleado.contractTypeName == ETipoSalario.ForHours.ToString())
            {
                //empleado.hourlySalary = 100;
                //var aux = 50;
                //empleado.Salario = empleado.Salario + aux;
                var salarioAnual = (120 * empleado.hourlySalary) * 12;
                empleado.hourlySalary = salarioAnual;
                //return empleado;
            }
            if(empleado.contractTypeName == ETipoSalario.Month.ToString())
            {
                var salarioAnual = empleado.monthlySalary * 12;
                empleado.monthlySalary = salarioAnual;
                //return empleado;
            }
            return empleado;
            
        }

        
    }
}

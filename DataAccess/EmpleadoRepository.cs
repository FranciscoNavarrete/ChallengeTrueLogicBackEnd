using Dapper;
using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using UnitOfWork;

namespace DataAccess
{
    public class EmpleadoRepository: Repository<Employees>, IEmpleadoRepository
    {
        public IUnitOfWork _unitOfWork;
        
        public EmpleadoRepository(string connectionString) : base(connectionString)
        {

        }

        //todo Hacer los dto
        public List<Employees> GetAllEmpleado()
        {
            //List<Employees> emplo = new List<Employees>();

            List<Employees> lstEmployees = HttpClientServices.ExecuteServiceWithOutBody<Employees>
                    ("http://masglobaltestapi.azurewebsites.net/api/Employees").Result;
            //emplo.Content = lstEmployees;


            return lstEmployees;
        }      
        
       
        //Retonar json
            //try
            //{
            //    using (var connection = new SqlConnection(_connectionString))
            //    {
            //        return connection.Query<Employees>(
            //           "dbo.GetAllEmpleado", null,
            //           commandType: System.Data.CommandType.StoredProcedure);
            //    }
            //}
            //catch (Exception ex)
            //{

            //    return null;
            //}

        

       
    }
}

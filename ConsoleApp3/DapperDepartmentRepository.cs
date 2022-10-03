using Dapper;
using IntroSQL;
using System;
using System.Collections.Generic; // not needed? why not highlighted? 
using System.Data;
using System.Linq; // not needed? 
using System.Text; // not needed? 
using System.Threading.Tasks; // not needed? 

namespace ConsoleApp3
{
    public class DapperDepartmentRepository : IDepartmentRepository
    {
        private readonly IDbConnection _connection;

        public DapperDepartmentRepository(IDbConnection connection) // why not void? 
        {
            _connection = connection;
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return _connection.Query<Department>("SELECT * FROM Departments;").ToList();
        }


        public void InsertDepartment(string newDepartmentName)
        {
            _connection.Execute("INSERT INTO DEPARTMENTS (Name) VALUES (@departmentName);",
        new { departmentName = newDepartmentName });
        }
    }
}

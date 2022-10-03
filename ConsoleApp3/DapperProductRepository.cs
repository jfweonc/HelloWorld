using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using IntroSQL;

namespace ConsoleApp3
{
    public class DapperProductRepository
    {
        private readonly IDbConnection _connection;
        public DapperProductRepository(IDbConnection connection) // why not void? 
        {
            _connection = connection;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _connection.Query<Product>("SELECT * FROM Products;").ToList();
        }
        public void InsertProduct(string newProductName)
        {
            _connection.Execute("INSERT INTO DEPARTMENTS (Name) VALUES (@departmentName);",
        new { departmentName = newProductName });
        }
    }
}

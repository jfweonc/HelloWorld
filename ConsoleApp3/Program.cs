using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using ConsoleApp3;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

string connString = config.GetConnectionString("DefaultConnection");
IDbConnection conn = new MySqlConnection(connString);
var repo = new DapperDepartmentRepository(conn);
Console.WriteLine("Type a new Department name");
var newDepartment = Console.ReadLine();
repo.InsertDepartment(newDepartment); 
var departments = repo.GetAllDepartments();
foreach(var dept in departments)
{
    Console.WriteLine(dept.Name);
}
var productRepo = new DapperProductRepository(conn);
Console.WriteLine("Type a new Product name");
// var newProduct = Console.ReadLine();
productRepo.InsertProduct(Console.ReadLine());
var Products = productRepo.GetAllProducts();
foreach (var pdct in Products)
{
    Console.WriteLine(pdct.Name);
}

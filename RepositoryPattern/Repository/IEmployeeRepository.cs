using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryPattern.Repository
{
    public interface IEmployeeRepository : IDisposable
    {
        IEnumerable<Employee> GetAllEmployee();
        Employee GetEmployeeById(int studentId);
        int AddEmployee(Employee employeeEntity);
        int UpdateEmployee(Employee employeeEntity);
        void DeleteEmployee(int employeeId);
    }
}
using System.Collections.Generic;

namespace MiniDemo.Model
{
    public interface IDataRepository
    {
        List<Employee> AddEmployee(Employee employee);
        List<Employee> GetEmployees();
        Employee PutEmployee(Employee employee);
        Employee GetEmployeeById(string id);
    }
}
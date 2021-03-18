using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPI.Model
{
    //public class EmployeeService

    //{
    //    private readonly ApplicationDbContext _db;

    //    public EmployeeService(ApplicationDbContext db)
    //    {
    //        _db = db;
    //    }

    //    //Get all empolyee
    //    public List<EmployeeInfo> GetEmployee()
    //    {
    //        var empList = _db.Employees.ToList();
    //        return empList;
    //    }

    //    //insert new employee

    //    public string Create(EmployeeInfo emp)
    //    {
    //        _db.Employees.Add(emp);
    //        _db.SaveChanges();
    //        return "Save Successfly";
    //    }

    //    //get by Id 
    //    public EmployeeInfo GetEmployeeById(Guid ID)
    //    {
    //        EmployeeInfo emp = _db.Employees.FirstOrDefault(s => s.ID == ID);
    //        return emp;
    //    }

    //    //update

    //    public string UpdateEmployee(EmployeeInfo emp)
    //    {
    //        _db.Employees.Update(emp);
    //        _db.SaveChanges();
    //        return "Updated";
    //    }

    //    //delete
    //    public string DeleteEmployee(EmployeeInfo emp)
    //    {
    //        _db.Employees.Remove(emp);
    //        _db.SaveChanges();
    //        return "Deleted";
    //    }
    //}
}

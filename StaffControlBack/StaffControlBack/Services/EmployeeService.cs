using Binding;
using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployees();
        IEnumerable<Position> GetPos();
        bool Add(Employee model);
    }
    public class EmployeeService : IEmployeeService
    {
        public readonly DB _db;
        public EmployeeService(DB db)
        {
            _db = db;
        }
        public IEnumerable<Employee> GetEmployees()
        {

            var result = new List<Employee>();
            try
            {
                result = _db.employees.ToList();


            }
            catch (System.Exception)
            {

            }
            return result;
        }
        public IEnumerable<Position> GetPos()
        {

            var result = new List<Position>();
            try
            {
                result = _db.positions.ToList();


            }
            catch (System.Exception)
            {

            }
            return result;
        }
        public bool Add(Employee model)
        {
            var emp = _db.employees.Where(x => x.Name.Equals(model.Name) && x.Surname.Equals(model.Surname)).FirstOrDefault();

            if (emp == null)
            {

                try
                {
                    _db.Add(model);
                    _db.SaveChanges();
                }
                catch (System.Exception)
                {
                    return false;
                }
            }
            return true;

        }
    }
}

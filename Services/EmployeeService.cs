using ReflectedXss.Data;
using System.Linq;

namespace ReflectedXss.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ApplicationDbContext context;

        public EmployeeService(ApplicationDbContext context)
        {
            this.context = context;
            if (!this.context.Employees.Any())
                InitSeedData();
        }

        public Employee[] GetEmployeesByName(string nameInfix)
        {
            if (nameInfix == null)
                nameInfix = string.Empty;

            var query = from Employee employee in this.context.Employees
                        where employee.Name.ToLowerInvariant().Contains(nameInfix.ToLowerInvariant())
                        select employee;

            return query.ToArray();
        }

        private void InitSeedData()
        {
            this.context.Employees.AddRange( new Employee[]
                {
                    new Employee { Name = "Jon Snow", Email = "jon@snow.got", Headline = "King of the north", Phone = "999-999-999", Salary = "50000" },
                    new Employee { Name = "Tyrion Lannister", Email = "tyrion@lannister.got", Headline = "Hand of the queen", Phone = "888-888-888", Salary = "100000" },
                    new Employee { Name = "Arya Stark", Email = "arya@stark.got", Headline = "No-one", Phone = "777-888-888", Salary = "22000" },
                    new Employee { Name = "Hodor", Email = "hodor@giant.got", Headline = "Holding the door", Phone = "123-345-666", Salary = "5000" },
                });
            this.context.SaveChanges();
        }
    }
}
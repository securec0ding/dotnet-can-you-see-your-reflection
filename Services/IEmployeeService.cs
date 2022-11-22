using ReflectedXss.Data;

namespace ReflectedXss.Services
{
    public interface IEmployeeService
    {
        Employee[] GetEmployeesByName(string nameInfix);
    }
}
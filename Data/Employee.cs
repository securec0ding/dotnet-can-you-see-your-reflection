using System.ComponentModel.DataAnnotations;

namespace ReflectedXss.Data
{
    public class Employee
    {
        public string Name { get; set; }
        [Key]
        public string Email { get; set; }
        public string Headline { get; set; }
        public string Phone { get; set; }
        public string Salary { get; set; }
    }
}
using ReflectedXss.Data;

namespace ReflectedXss.Models
{
    public class SearchResultModel
    {
        public string SearchTerm { get; set; }
        public Employee[] Employees { get; set; }
    }
}
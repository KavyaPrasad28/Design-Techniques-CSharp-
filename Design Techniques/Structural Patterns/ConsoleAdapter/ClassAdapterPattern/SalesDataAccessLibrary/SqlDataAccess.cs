using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDataAccessLibrary
{
    public class SalesDto
    {
        public string Name { get; set; }
        public int Sales { get; set; }
    }
    public class SqlDataAccess
    {
        public List<SalesDto> GetSalesData()
        {
            //gets the data from the database
            return new List<SalesDto>
            {
                new SalesDto {Name = "Jhon", Sales = 500},
                new SalesDto {Name = "Ravi", Sales = 1000},
                new SalesDto {Name = "Misa", Sales = 800}
            };
        }
    }
}

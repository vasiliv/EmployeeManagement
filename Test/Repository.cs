using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Repository : IRepository
    {
        private Employee _employee;

        public Repository(Employee employee)
        {
            _employee = employee;
        }

        public Employee GetbyId(int Id)
        {
            return 
        }
    }
}

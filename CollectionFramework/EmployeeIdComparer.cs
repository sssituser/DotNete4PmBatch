using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    internal class EmployeeIdComparer : Comparer<Employee>
    {
        public override int Compare(Employee x, Employee y)
        {
            if (x.EmployeeId <y.EmployeeId) return -1;
            if (x.EmployeeId >y.EmployeeId) return 1;
            return 0;
        }
    }
}

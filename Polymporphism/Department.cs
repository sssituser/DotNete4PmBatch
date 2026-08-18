using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymporphism
{
    internal class Department
    {
        int deptId;
        string deptName;
        string deptHead;
        public void SetDept(int deptId, string deptName,string deptHead)
        {
            this.deptId = deptId;
            this.deptName = deptName;
            this.deptHead = deptHead;
        }
        public void GetDept()
        {
            Console.WriteLine($"Dept id : {deptId}\tDept Name : {deptName}\tDeptHead : {deptHead}");
        }
    }
}

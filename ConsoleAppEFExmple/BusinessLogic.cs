using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFExmple
{
    internal class BusinessLogic
    {//EF Is An ORM
        purnidbClass Db = new purnidbClass();

        public bool RegisterFculty (faculty fac)
        {
            Db.faculty.Add(fac);
            return Db.SaveChanges()>0;
        }
        public bool CheckFaulty (faculty fac)
        {
            return Db.faculty.Where(x => x.fid == fac.fid).Count()>0;
        }
        public bool DeleteFaculty(faculty fac)
        {
            if (CheckFaulty(fac))
            {
                fac = Db.faculty.Where(x=>x.fid== fac.fid).FirstOrDefault();
                Db.faculty.Remove(fac);
                return Db.SaveChanges() > 0;
            }
            return false;
        }
        public bool UpdateFaculty(faculty fac) // old id, new name,new sal
        {

            if (CheckFaulty(fac))
            {
                faculty oldfac = Db.faculty.Where(x => x.fid == fac.fid).FirstOrDefault();
                oldfac.fname = fac.fname;
                oldfac.fsal = fac.fsal;
                return Db.SaveChanges() > 0;
            }
            return false;

        }
        public List<faculty> GetAllFaculty ()
        {
            return Db.faculty.ToList();
        }

        public faculty GetFacultyById(faculty fac)
        {
            if (CheckFaulty(fac))
            {
                return Db.faculty.Where(f=>f.fid==fac.fid).FirstOrDefault();
            }
            return null;
        }


        

    }
}

using System.Data.SqlClient;
using System.Data;


namespace AdpConnectedConsole
{
    internal class BusinessLogicLayer
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommandBuilder cmb;
        DataSet ds;
        DataRow row;
        public BusinessLogicLayer ()
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=priyadb;Integrated Security=True;Encrypt=False");
            da = new SqlDataAdapter("select * from student",con);
            cmb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds,"student");
            da.Update(ds.Tables["student"]); // 
            ds.Tables["student"].Constraints.Add("stuid_pk",ds.Tables["student"].Columns["stid"],true);
        }
        public bool AddStudent (int id,string name,int marks)
        {
            row = ds.Tables["student"].NewRow(); // creating  the row in dataset
            row["stid"] = id;
            row["stname"] = name;
            row["smarks"] = marks;
            ds.Tables["student"].Rows.Add(row);
            int res = da.Update(ds, "student");
            return res > 0;
        }

        public DataSet GetStudents()
        {
            return ds;
        }
        public DataRow FindStudentById(int id)
        {
            row = ds.Tables["student"].Rows.Find(id);
            if (row == null)
            {
                return null;
            }
            return row;
        }
        public bool UpdateStudent(int id,string name,int marks)
        {
            row = ds.Tables["student"].Rows.Find(id);
            row["stname"] = name;
            row["smarks"] = marks;
            int res = da.Update(ds, "student");
            return res > 0;
        }
        public bool DeleteStudentById(int id)
        {
            ds.Tables["student"].Rows.Find(id).Delete();
            int res = da.Update(ds, "student");
            return res > 0;
        }
        public bool CheckStudent(int id)
        {
            row = ds.Tables["student"].Rows.Find(id);
            if (row == null)
            {
                return false;
            }
            return true;
        }
    }
}

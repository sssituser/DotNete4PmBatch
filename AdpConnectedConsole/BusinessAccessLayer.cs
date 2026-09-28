
using System.Data.SqlClient;
using System.Data;

namespace AdpConnectedConsole
{
    internal class BusinessAccessLayer
    {
        SqlConnection con; // Referece variable create
        SqlCommand cmd;
        public BusinessAccessLayer ()
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=priyadb;Integrated Security=True;Encrypt=False");
            cmd = new SqlCommand();
            cmd.Connection = con;
            con.Close();
        }
        public bool RegisterEmployee(int eid,string ename,int esal)
        {
            cmd.CommandText = $"insert into employee values({eid},'{ename}',{esal})";
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res > 0;
        }
        public bool EditEmployee (int eid, string ename, int esal)
        {
            cmd.CommandText = $"update employee set ename = '{ename}',esal = {esal} where eid = {eid}";
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res > 0;
        }
        public bool DeleteEmployeeById (int eid)
        {
            cmd.CommandText = $"delete from employee where eid = {eid}";
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res > 0;
        }
        SqlDataReader dr;
        DataTable dt;
        public DataTable GetEmployees ()
        {
            cmd.CommandText = "select * from employee";
            con.Open();
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            con.Close();
            return dt;
        }

    }
}

using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
namespace AdpConnectedConsole
{
    internal class BusinessLogicc
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public BusinessLogicc ()
        {
           
            con = new SqlConnection ("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=adonetdb;Integrated Security=True;Encrypt=False");
            cmd = new SqlCommand();
            cmd.Connection = con;
            con.Close();
        }
        public async Task<bool>   AddEmployee (Employee emp)
        {
            cmd.CommandText = $"insert into employee values({emp.EmployeeId},'{emp.EmployeeName}',{emp.EmployeeSalary})";
            con.Open();
            Task<int> r =  cmd.ExecuteNonQueryAsync();
            int res = await r;
            con.Close();
            return  res > 0;
        }

        public async Task<bool> UpdateEmployee (Employee emp)
        {
            cmd.CommandText = $"update employee set ename='{emp.EmployeeName}',esal={emp.EmployeeSalary} where eid = {emp.EmployeeId}";
            con.Open();
            int res = await cmd.ExecuteNonQueryAsync();
            con.Close();
            return res > 0;
        }
        public async Task<bool> DeleteEmployee (Employee emp)
        {
            cmd.CommandText = $"delete from  employee where eid = {emp.EmployeeId}";
            con.Open();
            int res = await cmd.ExecuteNonQueryAsync();
            con.Close();
            return res > 0;
        }
        public async Task<DataTable> GetEmployees ()
        {
            cmd.CommandText = "select * from employee";
            con.Open();
            dr = await cmd.ExecuteReaderAsync();

            DataTable dt = new DataTable ();
            dt.Load(dr);
            con.Close();
            return dt;
        }
        public async Task<bool> CheckEmployee(Employee emp)
        {
            cmd.CommandText = $"select count(*) from employee where eid = {emp.EmployeeId}";
            con.Open();
            Task<int> res = (Task<int>)await cmd.ExecuteScalarAsync();
            int count = await res;
            con.Close();
            return count>0;

        }
    }
}

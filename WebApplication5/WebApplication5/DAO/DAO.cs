using System.Configuration;
using System.Data.SqlClient;

namespace mvcApplication.DAO
{
    public class DAO
    {
        //private string connectionString = @"data source=LOCALHOST;initial catalog=touragency;integrated security=True;pooling=False;MultipleActiveResultSets=True;App=EntityFramework";
        string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        protected SqlConnection Connection { get; set; }

        public void Connect()
        {
            Connection = new SqlConnection(connectionString);
            Connection.Open();
        }

        public void Disconnect()
        {
            Connection.Close();
        }
    }
}

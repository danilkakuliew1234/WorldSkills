using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WorldSkills
{
    class DataBase
    {
        public SqlConnection sqlConnection;
        public DataBase(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);
        }
        public void Connect()
        {
            if (sqlConnection.State.Equals(System.Data.ConnectionState.Closed))
                sqlConnection.Open();
        }
        public void Disconnect()
        {
            if (sqlConnection.State.Equals(System.Data.ConnectionState.Open))
                sqlConnection.Close();
        }
    }
}

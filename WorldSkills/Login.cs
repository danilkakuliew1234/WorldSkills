using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WorldSkills
{
    class Login
    {
        public DataBase dataBase;
        public Login(DataBase dataBase)
        {
            this.dataBase = dataBase;
        }
        public bool UserLogin(string login, string password)
        {
            dataBase.Connect();
            SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM Users WHERE login = '{login}' AND password = '{password}'", dataBase.sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);
            dataBase.Disconnect();

            if (dataTable.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}

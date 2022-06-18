using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Data;
//using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace Server
{
    class Modify
    {
        public Modify() { }

        SqlCommand sqlCommand; // dùng để truy vấn các câu lệnh insert , update,...
        SqlDataReader dataReader;//dùng để đọc dữ liêu trong bảng 

        public List<Account> Account(string query)
        {
            List<Account> accounts = new List<Account>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    accounts.Add(new Account(dataReader.GetString(0), dataReader.GetString(1)));
                }
                sqlConnection.Close();
            }
            return accounts;
        }

        /*public List<Phong> Phongs(string query)
        {
            List<Phong> Phongs= new List<Phong>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    //Phongs.Add(new Phong(dataReader.GetInt32(0)));
                    Phongs.Add(new Phong(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(4), dataReader.GetInt32(5)));
                }
                sqlConnection.Close();
            }
            return Phongs;
        }*/

        public void Command(string query)//dùng để đk tk
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery(); //thực thi câu truy vấn 
                sqlConnection.Close();
            }
        }
    }
}

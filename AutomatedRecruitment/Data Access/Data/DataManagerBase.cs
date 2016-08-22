using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Data
{
    public class DataManagerBase
    {
        private string _connectionString;

        public DataManagerBase()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        }


        public IDbConnection GetConnection(string connectionString)
        {
            SqlConnection SqlCon = new SqlConnection(connectionString);
            SqlCon.Open();
            return SqlCon;
        }

        public IDbCommand GetCommand(string procedureName, IDbConnection con, Dictionary<string, object> paramsDictionnary = null)
        {
            SqlCommand command = new SqlCommand(procedureName, (SqlConnection)con);
            command.CommandType = CommandType.StoredProcedure;
            if (paramsDictionnary != null)
            {
                foreach (KeyValuePair<string, object> pair in paramsDictionnary)
                {
                    command.Parameters.AddWithValue(pair.Key, pair.Value);
                }
            }
            return command;
        }


        public bool ExecuteCommand(string procedureName, Dictionary<string, object> paramsDictionnary = null)
        {
            using (SqlConnection con = (SqlConnection)GetConnection(_connectionString))
            {
                using (SqlCommand command = (SqlCommand)GetCommand(procedureName, con, paramsDictionnary))
                {
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }



        public List<T> ExecuteCollection<T>(string procedureName, Func<IDataReader, T> mapper, Dictionary<string, object> paramsDictionnary = null)
        {
            List<T> list = new List<T>();
            using (SqlConnection con = (SqlConnection)GetConnection(_connectionString))
            {
                using (SqlCommand command = (SqlCommand)GetCommand(procedureName, con, paramsDictionnary))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            T instance = mapper.Invoke(reader);
                            list.Add(instance);
                        }
                        return list;
                    }
                }
            }
        }


    }
}

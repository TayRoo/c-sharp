using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace DialNumber
{
    public class SqlLoader
    {
        public SqlLoader()
        {
        }
        public List<object> SqlLoading()
        {

            string queryString = "select * from sys.Animals";
            string connectionString = "Server=127.0.0.1; Port=3306;Uid=root; Password=sakina92;";
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            MySqlCommand mySqlCommand = new MySqlCommand(queryString, mySqlConnection);
            List<object> list = new List<object>();
            try
            {
                mySqlConnection.Open();
                MySqlDataReader rdr = mySqlCommand.ExecuteReader();

                while (rdr.Read())
                {

                    list.Add(rdr["name"]);

                }
                //GetAnimal getAnimal = new GetAnimal();
                //List<object> returnList = new List<object>();
                //returnList = getAnimal.GetAnimals("228", lliisstt);
                //foreach (var item in returnList)
                //{

                //    Console.WriteLine(item);
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine("catching" + ex);
            }
            finally
            {
                mySqlConnection.Close();
            }
            return list;
        }
    }
}

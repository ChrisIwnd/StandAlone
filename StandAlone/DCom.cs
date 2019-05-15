using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StandAlone
{
    /// <summary>
    /// DCom class is responsible for all actions between the program and the database.
    /// </summary>
    public static class DCom
    {
        //VARIABLES

        //This is the connection string that contains the path for our database.
        static string ConStr = "Server=127.0.0.1;port=3306;Database=teamproject;Uid=root;password=;convert zero datetime=true;";
        //This is our connection that we will have.
        static MySqlConnection Connection;

        //METHODS

        /// <summary>
        /// This method is to begin the connection between the dabase and the program.
        /// </summary>
        public static void Connect()
        {
            Connection = new MySqlConnection(ConStr);
            Connection.Open();
        }

        /// <summary>
        /// This method is to close the connection between the dabase and the program.
        /// </summary>
        public static void Close()
        {
            Connection.Close();
        }

        /// <summary>
        /// This method read a values from the database and creates it inside a DataTable.
        /// </summary>
        /// <param name="SqlStr">This is the mysql command that the method will run.</param>
        /// <returns>Returns a DataTable that contains the data of database.</returns>
        public static DataTable GetData(string SqlStr)
        {
            try
            {
                MySqlCommand SqlCmd = new MySqlCommand(SqlStr, Connection);
                MySqlDataReader DR;

                DR = SqlCmd.ExecuteReader();
                DataTable DT = new DataTable();
                DT.Load(DR);

                return DT;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method execute the command that users interact.
        /// </summary>
        /// <param name="SqlExec">This is the mysql command that the method will run.</param>
        /// <returns>Ιt returns true if there is no problem in execution, otherwise it returns false.</returns>
        public static bool Exec(string SqlExec)
        {
            try
            {
                MySqlCommand MyCommand = new MySqlCommand(SqlExec, Connection);
                MyCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// This method counts how many times there is a Value in a particular Row and Table.
        /// </summary>
        /// <param name="Table">The table we want to check.</param>
        /// <param name="Row">The row we want to check.</param>
        /// <param name="Value">The value we want to check.</param>
        /// <returns>Returns the true if it finds the value at least once else returns false.</returns>
        public static bool CountCheck(string Table, string Row, string Value)
        {
            string SqlExec = "SELECT COUNT(*) CNT FROM " + Table + " WHERE " + Row + " = '" + Value + "'";
            DataTable DT = DCom.GetData(SqlExec);

            Boolean Check;

            if ((long)DT.Rows[0][0] == 0)
            {
                Check = false;
            }
            else
            {
                Check = true;
            }

            return Check;
        }

        /// <summary>
        /// This method counts the entries of a particular table.
        /// </summary>
        /// <param name="Table">The table we want to check.</param>
        /// <returns>Returns the true if it finds at least one entrie else returns false.</returns>
        public static bool CountCheckTable(string Table)
        {
            string SqlExec = "SELECT COUNT(*) CNT FROM " + Table;
            DataTable DT = DCom.GetData(SqlExec);

            Boolean Check;

            if ((long)DT.Rows[0][0] == 0)
            {
                Check = false;
            }
            else
            {
                Check = true;
            }

            return Check;
        }
    }
}

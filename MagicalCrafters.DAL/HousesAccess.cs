using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalCrafters.DAL
{
    public class HousesAccess
    {
        #region Connections
        static string _connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        static string _errorLog = ConfigurationManager.ConnectionStrings["ErrorLog"].ConnectionString;
        #endregion

        #region POST
        public void PostPoints (int points, int house_Id)
        {
            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand("sp_AddHousePoints ", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@Points", points);
                cmd.Parameters.AddWithValue("@House_Id", house_Id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                using (StreamWriter writer = new StreamWriter(_errorLog))
                {
                    writer.Write("Create Exception: " + error);
                }
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
    }
}

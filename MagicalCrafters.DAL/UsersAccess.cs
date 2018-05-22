using MagicalCrafters.DAL.Models.DAL;
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
    public class UsersAccess
    {
        static string _connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        static string _errorLog = ConfigurationManager.ConnectionStrings["ErrorLog"].ConnectionString;

        public UsersDAL GetUser(int id)
        {
            //UsersDAL user = new UsersDAL();
            DataTable user = new DataTable();
            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand("sp_GetUserById", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@User_Id", id);
                con.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(user);
                }
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

            UsersDAL userToGet = new UsersDAL();
            userToGet.User_Id = Convert.ToInt32(user.Rows[0]["User_Id"]);
            userToGet.UserName = user.Rows[0]["UserName"].ToString();
            userToGet.User_Info.Role_Id = Convert.ToInt32(user.Rows[0]["Role_ID"]);
            userToGet.User_Info.Source_Id = Convert.ToInt32(user.Rows[0]["Source_Id"]);
            userToGet.User_Info.House_Id = Convert.ToInt32(user.Rows[0]["House_Id"]);
            userToGet.User_Info.Email = user.Rows[0]["Email"].ToString();
            userToGet.User_Info.isFlagged = Convert.ToBoolean(user.Rows[0]["isFlagged"]);
            userToGet.User_Info.CreatedDate = Convert.ToDateTime(user.Rows[0]["CreatedDate"]);
            userToGet.User_Info.LastModifiedBy = user.Rows[0]["LastModifiedBy"].ToString();
            userToGet.User_Info.LastModifiedDate = Convert.ToDateTime(user.Rows[0]["LastModifiedDate"]);
            return userToGet;
        }
    }
}

using MagicalCrafters.DAL.Models.DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace MagicalCrafters.DAL
{
    public class UsersAccess
    {
        #region Connections
        static string _connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        static string _errorLog = ConfigurationManager.ConnectionStrings["ErrorLog"].ConnectionString;
        #endregion

        #region GET
        public UsersDAL GetUser(int id)
        {
            DataTable user = new DataTable();
            UsersDAL userToGet = new UsersDAL();
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

                userToGet.User_Id = (int)user.Rows[0]["User_Id"];
                userToGet.UserName = user.Rows[0]["UserName"].ToString();
                //userToGet.Password = user.Rows[0]["Password"].ToString();
                //userToGet.Salt = user.Rows[0]["Salt"].ToString();
                userToGet.User_Info.Role_Id = (int)user.Rows[0]["Role_Id"];
                userToGet.User_Info.Source_Id = (int)user.Rows[0]["Source_Id"];
                userToGet.User_Info.House_Id = (int)user.Rows[0]["House_Id"];
                userToGet.User_Info.Email = user.Rows[0]["Email"].ToString();
                userToGet.User_Info.isFlagged = (bool)user.Rows[0]["isFlagged"];
                userToGet.User_Info.CreatedDate = (DateTime)user.Rows[0]["CreatedDate"];
                userToGet.User_Info.LastModifiedBy = user.Rows[0]["LastModifiedBy"].ToString();
                userToGet.User_Info.LastModifiedDate = (DateTime)user.Rows[0]["LastModifiedDate"];
                userToGet.User_Info.Points = (long)user.Rows[0]["Points"];
                userToGet.User_Info.House.Name = user.Rows[0]["Name"].ToString();
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
            return userToGet;
        }

        public UsersDAL GetUserByUserName(string username)
        {
            DataTable user = new DataTable();
            UsersDAL userToGet = new UsersDAL();
            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand("sp_GetUserByUserName", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@UserName", username);
                con.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(user);
                }

                userToGet.User_Id = (int)user.Rows[0]["User_Id"];
                userToGet.UserName = user.Rows[0]["UserName"].ToString();
                userToGet.Password = user.Rows[0]["Password"].ToString();
                userToGet.Salt = user.Rows[0]["Salt"].ToString();
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
            return userToGet;
        }

        public List<UsersDAL> GetUsers()
        {
            DataTable usersTable = new DataTable();
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand("sp_ViewUsers", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(usersTable);
                }
            }
            catch (Exception error)
            {
                using (StreamWriter writer = new StreamWriter(_errorLog))
                {
                    writer.Write("View Exception: " + error);
                }
            }
            finally
            {
                connection.Close();
            }
            return TableToListOfUsers(usersTable);
        }
        #endregion

        #region POST
        public void PostUser(UsersDAL user)
        {
            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand("sp_CreateUser", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@UserName", user.UserName);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Salt", user.Salt);
                cmd.Parameters.AddWithValue("@House_Id", user.User_Info.House_Id);
                cmd.Parameters.AddWithValue("@Email", user.User_Info.Email);
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

        #region PATCH
        public void PatchUser(UsersDAL user)
        {
            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand("sp_UpdateUser", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@User_Id", user.User_Id);
                cmd.Parameters.AddWithValue("@UserName", user.UserName);
                //cmd.Parameters.AddWithValue("@Salt", user.Salt);
                //cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Role_Id", user.User_Info.Role_Id);
                cmd.Parameters.AddWithValue("@Email", user.User_Info.Email);
                cmd.Parameters.AddWithValue("@isFlagged", user.User_Info.isFlagged);
                cmd.Parameters.AddWithValue("@LastModifiedBy", user.User_Info.LastModifiedBy);
                cmd.Parameters.AddWithValue("@LastModifiedDate", user.User_Info.LastModifiedDate);
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

        #region DELETE
        public void DeleteUser(int userId)
        {
            DataTable user = new DataTable();
            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand("sp_DeleteUser", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@User_Id", userId);
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

        #region Tables
        public List<UsersDAL> TableToListOfUsers(DataTable usersTable)
        {
            List<UsersDAL> dUsers = new List<UsersDAL>();
            if (usersTable != null && usersTable.Rows.Count > 0)
            {
                foreach (DataRow row in usersTable.Rows)
                {
                    UsersDAL dUser = new UsersDAL();
                    dUser = RowToUsers(row);
                    dUsers.Add(dUser);
                }
            }
            return dUsers;
        }
        public UsersDAL RowToUsers(DataRow tableRow)
        {
            UsersDAL userDAL = new UsersDAL();
            userDAL.User_Id = (int)tableRow["User_Id"];
            userDAL.UserName = tableRow["UserName"].ToString();
            userDAL.User_Info.Role_Id = (int)tableRow["Role_Id"];
            userDAL.User_Info.House_Id = (int)tableRow["House_Id"];
            userDAL.User_Info.Email = tableRow["Email"].ToString();
            userDAL.User_Info.isFlagged = (bool)tableRow["isFlagged"];
            userDAL.User_Info.CreatedDate = (DateTime)tableRow["CreatedDate"];
            userDAL.User_Info.LastModifiedBy = tableRow["LastModifiedBy"].ToString();
            userDAL.User_Info.LastModifiedDate = (DateTime)tableRow["LastModifiedDate"];
            userDAL.User_Info.Points = (long)tableRow["Points"];
            userDAL.User_Info.House.Name = tableRow["Name"].ToString();
            return userDAL;
        }
        #endregion
    }
}

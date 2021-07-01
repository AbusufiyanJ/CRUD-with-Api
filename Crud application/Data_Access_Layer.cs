using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Crud_application
{
    public class Data_Access_Layer
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ToString());
        SqlCommand cmd;
        DataTable dt;

        public int InsertData(ApplicationLayer ALObject)
        {
            try
            {
                using (cmd = new SqlCommand("Insert_User_Data", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Type", "ADD");
                    cmd.Parameters.AddWithValue("@Name", ALObject.Name);
                    cmd.Parameters.AddWithValue("@PhoneNo", ALObject.PhoneNo);
                    cmd.Parameters.AddWithValue("@JobRole", ALObject.JobRole);
                    cmd.Parameters.AddWithValue("@CurrentStatus", Convert.ToInt32(ALObject.CurrentStatus));
                    cmd.Parameters.AddWithValue("@Location", (ALObject.Location));
                    if (con.State.Equals(ConnectionState.Closed))
                        con.Open();
                    int result = cmd.ExecuteNonQuery();
                    con.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public int UpdateData(ApplicationLayer ALObject, int Id)
        {
            try
            {
                using (cmd = new SqlCommand("Insert_User_Data", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Type", "Update");
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@Name", ALObject.Name);
                    cmd.Parameters.AddWithValue("@PhoneNo", ALObject.PhoneNo);
                    cmd.Parameters.AddWithValue("@JobRole", ALObject.JobRole);
                    cmd.Parameters.AddWithValue("@CurrentStatus", Convert.ToInt32(ALObject.CurrentStatus));
                    cmd.Parameters.AddWithValue("@Location", (ALObject.Location));
                    if (con.State.Equals(ConnectionState.Closed)) con.Open();
                    int result = cmd.ExecuteNonQuery();
                    con.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public int DeleteData(int Id)
        {
            try
            {
                using (cmd = new SqlCommand("Insert_User_Data", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Type", "Delete");
                    cmd.Parameters.AddWithValue("@Id", Id);
                    if (con.State.Equals(ConnectionState.Closed)) con.Open();
                    int result = cmd.ExecuteNonQuery();
                    con.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public DataTable BindGrid()
        {
            using (cmd = new SqlCommand("Insert_User_Data", con))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Type", "Get_For_Grid");
                    if (con.State.Equals(ConnectionState.Closed)) con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);
                    con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public DataTable GetById(int Id)
        {
            using (cmd = new SqlCommand("Insert_User_Data", con))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Type", "Get_By_Id");
                    cmd.Parameters.AddWithValue("@Id", Id);
                    if (con.State.Equals(ConnectionState.Closed)) con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);
                    con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
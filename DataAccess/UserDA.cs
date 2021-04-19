using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BusinessObject;

namespace DataAccess
{
    public class UserDA
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CompanyPrinterDB"].ToString());

        //---------------------------------------Designations---------------------------------------
        public DataTable GetAllDesignation()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("dbo.GetAllDesignation", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cmd.Dispose();
            return dt;
        }

        public void AddDesignation(Designation designation)
        {         
                con.Open();
                SqlCommand cmd = new SqlCommand("dbo.AddDesignation", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@designationName", designation.DesignationName);
                cmd.Parameters.AddWithValue("@status", designation.Status);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);    
        }

        public void UpdateDesignation(Designation designation)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("dbo.UpdateDesignation", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@designationID", designation.DesignationID);
            cmd.Parameters.AddWithValue("@designationName", designation.DesignationName);
            cmd.Parameters.AddWithValue("@status", designation.Status);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
        }

        public void DeleteDesignation(int id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("dbo.DeleteDesignation", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@designationID", id);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
        }

        //---------------------------------------User---------------------------------------
        public DataTable GetAllUser()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("dbo.GetAllUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cmd.Dispose();
            return dt;
        }
        public void AddUsers(CreateUser user)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("dbo.AddNewUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@lastname", user.LastName);
            cmd.Parameters.AddWithValue("@firstname", user.FirstName);
            cmd.Parameters.AddWithValue("@designationid", user.DesignationID);
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.Parameters.AddWithValue("@username", user.UserName);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@address", user.Address);
            cmd.Parameters.AddWithValue("@dob", user.DOB);
            cmd.Parameters.AddWithValue("@createddate", user.CreatedDate);
            cmd.Parameters.AddWithValue("@LastModificationDate", user.LastModificationDate);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
        }
        public void UpdateUsers(CreateUser user)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("dbo.UpdateUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userID", user.UserID);
            cmd.Parameters.AddWithValue("@username", user.UserName);
            cmd.Parameters.AddWithValue("@lastname", user.LastName);
            cmd.Parameters.AddWithValue("@firstname", user.FirstName);
            cmd.Parameters.AddWithValue("@designationid", user.DesignationID);
            cmd.Parameters.AddWithValue("@email", user.Email);         
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@address", user.Address);
            cmd.Parameters.AddWithValue("@dob", user.DOB);
            cmd.Parameters.AddWithValue("@createddate", user.CreatedDate);
            cmd.Parameters.AddWithValue("@LastModificationDate", user.LastModificationDate);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
        }

        public DataTable SearchUser(string username)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("dbo.searchUser", con);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cmd.Dispose();
            return dt;
        }
        //---------------------------------------PrinterMake---------------------------------------
        public DataTable GetAllPrinterMake()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("dbo.GetAllPrinterMake", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cmd.Dispose();
            return dt;
        }

        public void AddPrinterMake(PrinterMake printerMake)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("dbo.AddPrinterMake", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PrinterMakeName", printerMake.PrinterMakeName);
            cmd.Parameters.AddWithValue("@Status", printerMake.Status);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
        }

        public void UpdatePrinterMake(PrinterMake printerMake)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("dbo.UpdatePrinterMake", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@printerMakeID", printerMake.PrinterMakeID);
            cmd.Parameters.AddWithValue("@PrinterMakeName", printerMake.PrinterMakeName);
            cmd.Parameters.AddWithValue("@Status", printerMake.Status);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
        }

    }
}

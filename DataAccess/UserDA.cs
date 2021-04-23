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

        public int AddDesignation(Designation designation)
        {         
                con.Open();
                SqlCommand cmd = new SqlCommand("dbo.AddDesignation", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@designationName", designation.DesignationName);
                cmd.Parameters.AddWithValue("@status", designation.Status);
                int Result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                return Result;   
        }

        public int UpdateDesignation(Designation designation)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("dbo.UpdateDesignation", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@designationID", designation.DesignationID);
            cmd.Parameters.AddWithValue("@designationName", designation.DesignationName);
            cmd.Parameters.AddWithValue("@status", designation.Status);
            int Result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            return Result;
        }

        public int DeleteDesignation(int id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("dbo.DeleteDesignation", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@designationID", id);
            int Result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            return Result;
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
        public int AddUsers(CreateUser user)
        {
            user.CreatedDate = DateTime.Now;
            user.LastModificationDate = DateTime.Now;

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
            int Result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            return Result;
        }
        public int UpdateUsers(CreateUser user)
        {   
             user.CreatedDate = DateTime.Now;
            user.LastModificationDate = DateTime.Now;
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
            int Result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            return Result;
        }

        public int DeleteUsers(int id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("dbo.DeleteUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userID",id);
            int Result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            return Result;
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

        public int AddPrinterMake(PrinterMake printerMake)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("dbo.AddPrinterMake", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PrinterMakeName", printerMake.PrinterMakeName);
            cmd.Parameters.AddWithValue("@Status", printerMake.Status);
            int Result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            return Result;
        }

        public int UpdatePrinterMake(PrinterMake printerMake)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("dbo.UpdatePrinterMake", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@printerMakeID", printerMake.PrinterMakeID);
            cmd.Parameters.AddWithValue("@PrinterMakeName", printerMake.PrinterMakeName);
            cmd.Parameters.AddWithValue("@Status", printerMake.Status);
            int Result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            return Result;
        }

        //---------------------------------------Printers---------------------------------------
        public DataTable GetAllPrinters()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("dbo.GetAllPRinters", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cmd.Dispose();
            return dt;
        }

        public int AddPrinter(Printer printer)
        {
            printer.CreatedDate = DateTime.Now;
            printer.LastModificationDate = DateTime.Now;
            printer.Status = 1;
            con.Open();
            SqlCommand cmd = new SqlCommand("dbo.AddPrinters", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PrinterName", printer.PrinterName);
            cmd.Parameters.AddWithValue("@FolderToMonitor", printer.FolderToMonitor);
            cmd.Parameters.AddWithValue("@OutputType", printer.OutputType);
            cmd.Parameters.AddWithValue("@FileOutput", printer.FileOutput);
            cmd.Parameters.AddWithValue("@PrinterMakeID", printer.PrinterMakeID);
            cmd.Parameters.AddWithValue("@Active", printer.Active);
            cmd.Parameters.AddWithValue("@Status", printer.Status);
            cmd.Parameters.AddWithValue("@CreatedDate", printer.CreatedDate);
            cmd.Parameters.AddWithValue("@LastModificationDate", printer.LastModificationDate);
            int Result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            return Result;
        }

        public int UpdatePrinter(Printer printer)
        {
            //printer.CreatedDate = DateTime.Now;
            printer.LastModificationDate = DateTime.Now;
            printer.Status = 1;
            con.Open();
            SqlCommand cmd = new SqlCommand("dbo.UpdatePrinters", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PrintersID", printer.EngenPrintersID);
            cmd.Parameters.AddWithValue("@PrinterName", printer.PrinterName);
            cmd.Parameters.AddWithValue("@FolderToMonitor", printer.FolderToMonitor);
            cmd.Parameters.AddWithValue("@OutputType", printer.OutputType);
            cmd.Parameters.AddWithValue("@FileOutput", printer.FileOutput);
            cmd.Parameters.AddWithValue("@PrinterMakeID", printer.PrinterMakeID);
            cmd.Parameters.AddWithValue("@Active", printer.Active);
            cmd.Parameters.AddWithValue("@Status", printer.Status);
            cmd.Parameters.AddWithValue("@CreatedDate", printer.CreatedDate);
            cmd.Parameters.AddWithValue("@LastModificationDate", printer.LastModificationDate);
            int Result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            return Result;
        }

        //---------------------------------------Documents---------------------------------------
        public DataTable GetAllDocuments()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("dbo.GetAllDocuments", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cmd.Dispose();
            return dt;
        }

        public int AddDocuments(Document docs)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("dbo.UploadDoc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@printerID", docs.printerID);
            cmd.Parameters.AddWithValue("@userID", docs.userID);
            cmd.Parameters.AddWithValue("@docType", docs.DocType);
            cmd.Parameters.AddWithValue("@docUrl", docs.DocUrl);
            cmd.Parameters.AddWithValue("@createdDate", docs.CreatedDate);
            int Result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            return Result;
        }

        public int UpdateDocument(Document docs)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("dbo.UpdateDoc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@docId", docs.DocID);
            cmd.Parameters.AddWithValue("@printerID", docs.printerID);
            cmd.Parameters.AddWithValue("@userID", docs.userID);
            cmd.Parameters.AddWithValue("@docType", docs.DocType);
            cmd.Parameters.AddWithValue("@docUrl", docs.DocUrl);
            cmd.Parameters.AddWithValue("@createdDate", docs.CreatedDate);
            int Result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            return Result;
        }
    }
}

using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslogic
{
    public class UserBL
    {
        UserDA userDA = new UserDA();
        //-----------------------------------Designation-------------------------------
        public DataTable getAllDesignation()
        {
            try
            {
               
                return userDA.GetAllDesignation();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void addDesignation(Designation designation)
        {
            try
            {          
                userDA.AddDesignation(designation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void updateDesignation(Designation designation)
        {
            try
            {     
                userDA.UpdateDesignation(designation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void deleteDesignation(int id)
        {
            try
            {
                userDA.DeleteDesignation(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public void deleteDesignation(int id)
        //{
        //    try
        //    {
        //        userDA.DeleteDesignation(id);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //-----------------------------------User-------------------------------
        public DataTable getAllUser()
        {
            try
            {

                return userDA.GetAllUser();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void addUser(CreateUser user)
        {
            try
            {
                userDA.AddUsers(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void updateUser(CreateUser user)
        {
            try
            {
                userDA.UpdateUsers(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void deleteUser(int id)
        {
            try
            {
                userDA.DeleteUsers(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable searchUser(string username)
        {
            try
            {

                return userDA.SearchUser(username);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //-----------------------------------PrinterMake-------------------------------
        public DataTable getAllPrinterMake()
        {
            try
            {

                return userDA.GetAllPrinterMake();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void addPrinterMake(PrinterMake printerMake)
        {
            try
            {
                userDA.AddPrinterMake(printerMake);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

 
        public void updatePrinter(PrinterMake printerMake)
        {
            try
            {
                userDA.UpdatePrinterMake(printerMake);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void deletePrinterMake(int id)
        {
            try
            {
                userDA.DeletePrinterMake(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //-----------------------------------Printer-------------------------------
        public DataTable getAllPrinters()
        {
            try
            {

                return userDA.GetAllPrinters();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void addPrinter(Printer printer)
        {
            try
            {
                userDA.AddPrinter(printer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void updatePrinter(Printer printer)
        {
            try
            {
                userDA.UpdatePrinter(printer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void deletePrinter(int id)
        {
            try
            {
                userDA.DeletePrinter(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //-----------------------------------Documents-------------------------------
        public DataTable getAllDocuments()
        {
            try
            {

                return userDA.GetAllDocuments();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void addDoc(Document doc)
        {
            try
            {
                userDA.AddDocuments(doc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void updateDoc(Document doc)
        {
            try
            {
                userDA.UpdateDocument(doc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

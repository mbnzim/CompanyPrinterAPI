﻿using BusinessObject;
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
    }
}

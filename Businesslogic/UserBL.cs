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
    }
}

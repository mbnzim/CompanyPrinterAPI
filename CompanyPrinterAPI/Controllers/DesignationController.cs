using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess;
using Businesslogic;
using BusinessObject;

namespace CompanyPrinterAPI.Controllers
{
    [AllowAnonymous]
    public class DesignationController : ApiController
    {
        UserBL userBL = new UserBL();
        [AllowAnonymous]
        //GetAll Designations
        public HttpResponseMessage Get()
        {
         
            return Request.CreateResponse(HttpStatusCode.OK, userBL.getAllDesignation());
        }
        [AllowAnonymous]
        //Add Designation
        public string Post(Designation designation)
        {
            try
            {           
                userBL.addDesignation(designation);
                return "Added Successfully!!";
            }
            catch (Exception)
            {
                return "Failed to Add!!";
            }          
        }

        //Update Designation
        [AllowAnonymous]
        public string Put(Designation designation)
        {
            try
            {
                userBL.updateDesignation(designation);
                return "Update Successfully!!";
            }
            catch (Exception)
            {
                return "Failed to Update!!";
            }
        }

        [AllowAnonymous]
        [Route("api/Designation/Delete")]
        [HttpPut]
        public string Delete(int id)
        {
            try
            {
                userBL.deleteDesignation(id);
                return "User has been deleted Successfully!!";
            }
            catch (Exception)
            {
                return "User Failed to Deleted!!";
            }
        }

        //[AllowAnonymous]
        //public string Delete(int id)
        //{
        //    try
        //    {
        //        userBL.deleteDesignation(id);
        //        return "Delete Successfully!!";
        //    }
        //    catch (Exception)
        //    {
        //        return "Failed to Delete!!";
        //    }
        //}
    }
}

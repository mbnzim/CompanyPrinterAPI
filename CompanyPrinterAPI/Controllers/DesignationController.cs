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
                return "Designation added Successfully!!";
            }
            catch (Exception)
            {
                return "Failed to Add Designation!!";
            }          
        }

        //Update Designation
        [AllowAnonymous]
        public string Put(Designation designation)
        {
            try
            {
                userBL.updateDesignation(designation);
                return "Designation Updated Successfully!!";
            }
            catch (Exception)
            {
                return "Failed to Update Designation!!";
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
                return "Designation deleted Successfully!!";
            }
            catch (Exception)
            {
                return "Failed to deleted Designation!!";
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

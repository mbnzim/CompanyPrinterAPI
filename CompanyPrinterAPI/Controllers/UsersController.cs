using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess;
using Businesslogic;
using BusinessObject;

namespace CompanyPrinterAPI.Controllers
{
    public class UsersController : ApiController
    {
        UserBL userBL = new UserBL();

         [AllowAnonymous]
        //[Authorize]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, userBL.getAllUser());
        }

        [AllowAnonymous]
        public string Post(CreateUser user)
        {
            try
            {
                userBL.addUser(user);
                return "Added Successfully!!";
            }
            catch (Exception)
            {
                return "Failed to Add!!";
            }
        }
        public string Put(CreateUser user)
        {
            try
            {
                userBL.updateUser(user);
                return "Added Successfully!!";
            }
            catch (Exception)
            {
                return "Failed to Add!!";
            }
        }

        [Route("api/Users/Delete")]
        [HttpPut]
        public string Delete(int id)
        {
            try
            {
                userBL.deleteUser(id);
                return "User has been deleted Successfully!!";
            }
            catch (Exception)
            {
                return "User Failed to Deleted!!";
            }
        }


        [Route("api/Users/SearchUser")]
        [HttpGet]
        public HttpResponseMessage Get(string username)
        {
            return Request.CreateResponse(HttpStatusCode.OK, userBL.searchUser(username));
        }
    }
}

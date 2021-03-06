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
                return "User added Successfully!!";
            }
            catch (Exception)
            {
                return "Failed to Add User!!";
            }
        }
        [AllowAnonymous]
        public string Put(CreateUser user)
        {
            try
            {
                userBL.updateUser(user);
                return "User updated Successfully!!";
            }
            catch (Exception)
            {
                return "Failed to update user!!";
            }
        }
        [AllowAnonymous]
        [Route("api/Users/Delete")]
        [HttpPut]
        public string Delete(int id)
        {
            try
            {
                userBL.deleteUser(id);
                return "User deleted Successfully!!";
            }
            catch (Exception)
            {
                return "User Failed to Deleted!!";
            }
        }

        [AllowAnonymous]
        [Route("api/Users/SearchUser")]
        [HttpGet]
        public HttpResponseMessage Get(string username)
        {
            return Request.CreateResponse(HttpStatusCode.OK, userBL.searchUser(username));
        }
    }
}

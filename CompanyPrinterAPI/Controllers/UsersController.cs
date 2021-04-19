using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
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
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, userBL.getAllUser());
        }

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
    }
}

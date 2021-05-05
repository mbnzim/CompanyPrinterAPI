using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Businesslogic;
using BusinessObject;

namespace CompanyPrinterAPI.Controllers
{
    public class DocumentController : ApiController
    {
        UserBL userBL = new UserBL();

        //GetAll Documents
        [AllowAnonymous]
        public HttpResponseMessage Get()
        {

            return Request.CreateResponse(HttpStatusCode.OK, userBL.getAllDocuments());
        }

        //Add Document
        [AllowAnonymous]
        public string Post(Document doc)
        {
            try
            {
                userBL.addDoc(doc);
                return "Document added Successfully!!";
            }
            catch (Exception)
            {
                return "Failed to add Document!!";
            }
        }

        //Update Document
        [AllowAnonymous]
        public string Put(Document doc)
        {
            try
            {
                userBL.updateDoc(doc);
                return "Document Updated Successfully!!";
            }
            catch (Exception)
            {
                return "Failed to Update Document!!";
            }
        }
    }
}

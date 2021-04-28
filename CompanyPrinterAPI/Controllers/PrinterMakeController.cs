using Businesslogic;
using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CompanyPrinterAPI.Controllers
{
    public class PrinterMakeController : ApiController
    {
        UserBL userBL = new UserBL();
        //GetAll PrinterMake
        [AllowAnonymous]
        public HttpResponseMessage Get()
        {

            return Request.CreateResponse(HttpStatusCode.OK, userBL.getAllPrinterMake());
        }

        //Add PrinterMake
        [AllowAnonymous]
        public string Post(PrinterMake printerMake)
        {
            try
            {
                userBL.addPrinterMake(printerMake);
                return "Added Successfully!!";
            }
            catch (Exception)
            {
                return "Failed to Add!!";
            }
        }

        //Update PrinterMake
        [AllowAnonymous]
        public string Put(PrinterMake printerMake)
        {
            try
            {
                userBL.updatePrinter(printerMake);
                return "Update Successfully!!";
            }
            catch (Exception)
            {
                return "Failed to Update!!";
            }
        }

        [AllowAnonymous]
        [Route("api/PrinterMake/Delete")]
        [HttpPut]
        public string Delete(int id)
        {
            try
            {
                userBL.deletePrinterMake(id);
                return "User has been deleted Successfully!!";
            }
            catch (Exception)
            {
                return "User Failed to Deleted!!";
            }
        }



    }
}

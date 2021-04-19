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
        public HttpResponseMessage Get()
        {

            return Request.CreateResponse(HttpStatusCode.OK, userBL.getAllPrinterMake());
        }

        //Add PrinterMake
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

    }
}

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
    public class PrinterController : ApiController
    {
        UserBL userBL = new UserBL();

        //GetAll Printer
        public HttpResponseMessage Get()
        {

            return Request.CreateResponse(HttpStatusCode.OK, userBL.getAllPrinters());
        }

        //Add Printer
        public string Post(Printer printer)
        {
            try
            {
                userBL.addPrinter(printer);
                return "Added Successfully!!";
            }
            catch (Exception)
            {
                return "Failed to Add!!";
            }
        }

        //Update Printer
        public string Put(Printer printer)
        {
            try
            {
                userBL.updatePrinter(printer);
                return "Update Successfully!!";
            }
            catch (Exception)
            {
                return "Failed to Update!!";
            }
        }
    }
}

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
        [AllowAnonymous]
        public HttpResponseMessage Get()
        {

            return Request.CreateResponse(HttpStatusCode.OK, userBL.getAllPrinters());
        }

        //Add Printer
        [AllowAnonymous]
        public string Post(Printer printer)
        {
            try
            {
                userBL.addPrinter(printer);
                return "Printer added Successfully!!";
            }
            catch (Exception)
            {
                return "Failed to add Printer!!";
            }
        }

        //Update Printer
        [AllowAnonymous]
        public string Put(Printer printer)
        {
            try
            {
                userBL.updatePrinter(printer);
                return "Printer Updated Successfully!!";
            }
            catch (Exception)
            {
                return "Failed to Update Printer!!";
            }
        }


        [AllowAnonymous]
        [Route("api/Printer/Delete")]
        [HttpPut]
        public string Delete(int id)
        {
            try
            {
                userBL.deletePrinter(id);
                return "Printer(s) deleted Successfully!!";
            }
            catch (Exception)
            {
                return "Failed to deleted Printer(s)!!";
            }
        }

    }
}

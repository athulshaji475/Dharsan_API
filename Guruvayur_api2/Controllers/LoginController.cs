using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Guruvayur_api2.Models;
using Guruvayur_api2.Class;


namespace Guruvayur_api2.Controllers
{
    public class LoginController : ApiController
    {

        Guruvayur_VisitEntities obj = new Guruvayur_VisitEntities();


        [HttpPost]
        public IEnumerable<InsertOtp_Result> Insertotp(string phone)
        {

            try
            {
                string otp = Utils.CreateOTP(5);  //UtilsController.CreateOTP(5);
               // Utils.SendSmS(phone, "Guruvayur Devaswom: " + otp + " is the Password to access your Account on Guruvayur Devaswom APP");
                Utils.SendWatsapp(phone, "Guruvayur Devaswom: " + otp + " is the Password to access your Account on Guruvayur Devaswom APP");
               return (obj.InsertOtp(phone, otp));
            } catch (Exception ex)

            {
                throw ex;
            }

        }

       [HttpPost]
       public IEnumerable<CheckOtpFromOtp_Tb_Result>CheckOtp(string otp,string phone)
        {
            try
            {
                return (obj.CheckOtpFromOtp_Tb(otp, phone));
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}

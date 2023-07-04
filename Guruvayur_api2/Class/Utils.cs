using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Configuration;

namespace Guruvayur_api2.Class
{
    public class Utils
    {
        public static string CreateOTP(int length)
        {
            const string valid = "1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        /* public static bool SendMailPassword(string toMail, string otp)
         {
             try
             {
                 //using (MailMessage mm = new MailMessage("support@peacegate.in", toMail))
                 //{
                 //    mm.Subject = "Peacegate Account -" + otp + " is your Password for secure access";
                 //    mm.Body = "Hi,<br> Greetings! <br> You are just a step away from accessing your Peacegate account. <br> We are sharing a Password to access your account.<br> Your Password : <b>" + otp + "</b><br>Best Regards, <br> Peacegate App";
                 //    mm.IsBodyHtml = true;
                 //    SmtpClient smtp = new SmtpClient();
                 //    smtp.Host = "smtp.zoho.in";
                 //    smtp.EnableSsl = true;
                 //    NetworkCredential NetworkCred = new NetworkCredential("support@peacegate.in", "PeaceGate@2018");
                 //    smtp.UseDefaultCredentials = false;
                 //    smtp.Credentials = NetworkCred;
                 //    smtp.Port = 587;
                 //    smtp.Send(mm);
                 //    return true;
                 //}
                 string SendGridKey = WebConfigurationManager.AppSettings["SendGridKey"];
                 var Recipient = toMail;
                 var apiKey = SendGridKey;
                 var client = new SendGridClient(apiKey);
                 var from = new EmailAddress("noreply@guruvayurdevaswom.in", "Guruvayur Devaswom ");
                 //var subject = "Malliyoor Temple APP Account -" + otp + " is your Password for secure access";
                 var subject = "Guruvayur Devaswom APP Account -" + otp + " is your Password for secure access";
                 var to = new EmailAddress(Recipient, "");
                 var plainTextContent = "Hi,<br> Greetings! <br> You are just a step away from accessing your Guruvayur Devaswom APP account. <br> We are sharing a Password to access your account.<br> Your Password : <b>" + otp + "</b><br>Best Regards, <br> Guruvayur Devaswom";
                 var htmlContent = "Hi,<br> Greetings! <br> You are just a step away from accessing your Guruvayur Devaswom APP account. <br> We are sharing a Password to access your account.<br> Your Password : <b>" + otp + "</b><br>Best Regards, <br> Guruvayur Devaswom ";
                 var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                 var response = client.SendEmailAsync(msg);
                 return true;
             }
             catch (Exception e)
             {

                 return true;
             }
         }*/
        /*  public static bool SendMail(string toMail, string body, string sub)
          {
              try
              {
                  string SendGridKey = WebConfigurationManager.AppSettings["SendGridKey"];
                  var Recipient = toMail;
                  var apiKey = SendGridKey;
                  var client = new SendGridClient(apiKey);
                  var from = new EmailAddress("noreply@guruvayurdevaswom.in", "Guruvayur Devaswom ");
                  var subject = sub;
                  var to = new EmailAddress(Recipient, "");

                  var plainTextContent = "Hi,<br> Greetings! <br>" + body + "<br>Best Regards, <br> Guruvayur Devaswom ";
                  var htmlContent = "Hi,<br> Greetings! <br>" + body + "<br>Best Regards, <br> Guruvayur Devaswom ";
                  var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                  var response = client.SendEmailAsync(msg);
                  return true;
              }
              catch (Exception e)
              {

                  return true;
              }
          }
          */



        public static void SendWatsapp(string numbers, string subj)
        {
            try
            {
                //string sURL;
                //sURL = "http://sapteleservices.com/SMS_API/sendsms.php?username=Sopanam&password=Kamath*123&mobile=" + numbers + "&sendername=SOPANM&message=" + HttpUtility.UrlEncode(subj) + "&routetype=1";
                //WebRequest wrGETURL;
                //wrGETURL = WebRequest.Create(sURL);
                ////byte b = default(Byte);
                //Stream objStream;
                //objStream = wrGETURL.GetResponse().GetResponseStream();
                //StreamReader objReader = new StreamReader(objStream);
                //string sLine = "";
                ////int i = 0;
                //sLine = objReader.ReadLine();

                string sURL;

                string url;


                sURL = "http://alerts.smsclogin.com/api/web2sms.php?workingkey=Ac06d3fd71688503e792e12ea6f92f624&sender=GVRDSM &to=" + numbers + "&message=" + HttpUtility.UrlEncode(subj);
                url = "https://chatspaz.com/api/v1/send/wa/message?api_key=pzcJtCr0pxFsOI6XzdUMhjZCG6Q0jbMx&instance=41550013&to=" + numbers + "&type=text&message=" + subj;

          

                //sURL = "http://alerts.smsclogin.com/api/web2sms.php?workingkey=Ac06d3fd71688503e792e12ea6f92f624&sender=GVRDSM&to=" + numbers + "&message=" + HttpUtility.UrlEncode(subj);


                WebRequest wrGETURL;
                wrGETURL = WebRequest.Create(url);
                //byte b = default(Byte);
                Stream objStream;
                objStream = wrGETURL.GetResponse().GetResponseStream();
                StreamReader objReader = new StreamReader(objStream);
                string sLine = "";
                //int i = 0;
                sLine = objReader.ReadLine();





            }
            catch (Exception e)
            {
                throw e;
            }

        }









        public static void SendSmS(string numbers, string subj)
        {
            try
            {
                //string sURL;
                //sURL = "http://sapteleservices.com/SMS_API/sendsms.php?username=Sopanam&password=Kamath*123&mobile=" + numbers + "&sendername=SOPANM&message=" + HttpUtility.UrlEncode(subj) + "&routetype=1";
                //WebRequest wrGETURL;
                //wrGETURL = WebRequest.Create(sURL);
                ////byte b = default(Byte);
                //Stream objStream;
                //objStream = wrGETURL.GetResponse().GetResponseStream();
                //StreamReader objReader = new StreamReader(objStream);
                //string sLine = "";
                ////int i = 0;
                //sLine = objReader.ReadLine();

                string sURL;




                sURL = "http://alerts.smsclogin.com/api/web2sms.php?workingkey=Ac06d3fd71688503e792e12ea6f92f624&sender=GVRDSM &to=" + numbers + "&message=" + HttpUtility.UrlEncode(subj);


                //sURL = "http://alerts.smsclogin.com/api/web2sms.php?workingkey=Ac06d3fd71688503e792e12ea6f92f624&sender=GVRDSM&to=" + numbers + "&message=" + HttpUtility.UrlEncode(subj);


                WebRequest wrGETURL;
                wrGETURL = WebRequest.Create(sURL);
                //byte b = default(Byte);
                Stream objStream;
                objStream = wrGETURL.GetResponse().GetResponseStream();
                StreamReader objReader = new StreamReader(objStream);
                string sLine = "";
                //int i = 0;
                sLine = objReader.ReadLine();





            }
            catch (Exception e)
            {
                throw e;
            }

        }


        public static bool SaveImage(string path, string base64string)
        {
            try
            {
                string filePath = HttpContext.Current.Server.MapPath(path);
                File.WriteAllBytes(filePath, Convert.FromBase64String(base64string.Split(',')[1]));
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }



        public static void SendSmSNotification(string numbers, string subj)
        {
            try
            {
                if (numbers != "9446314747")
                //if(numbers != "9847398659")
                {
                    string sURL;
                    //  sURL = "http://sapteleservices.com/SMS_API/sendsms.php?username=Sopanam&password=Kamath*123&mobile=" + numbers + "&sendername=SOPANM&message=" + HttpUtility.UrlEncode(subj) + "&routetype=1";
                    sURL = "http://alerts.smsclogin.com/api/web2sms.php?workingkey=Ac06d3fd71688503e792e12ea6f92f624&sender=GVRDSM &to=" + numbers + "&message=" + HttpUtility.UrlEncode(subj);
                    WebRequest wrGETURL;
                    wrGETURL = WebRequest.Create(sURL);
                    //byte b = default(Byte);
                    Stream objStream;
                    objStream = wrGETURL.GetResponse().GetResponseStream();
                    StreamReader objReader = new StreamReader(objStream);
                    string sLine = "";
                    //int i = 0;
                    sLine = objReader.ReadLine();

                    //BookSeva_AppEntities BS = new BookSeva_AppEntities();
                    //var cp = BS.spInsertSmsDelivery(0, numbers, numbers, subj, 0, "Delivered").SingleOrDefault();
                }
            }
            catch (Exception e)
            {

            }

        }



     /*   public static bool SendBookingMail(string toMail, string body, string sub)
        {
            try
            {

                string SendGridKey = WebConfigurationManager.AppSettings["SendGridKey"];
                var Recipient = toMail;
                var apiKey = SendGridKey;
                var client = new SendGridClient(apiKey);
                var from = new EmailAddress("noreply@guruvayurdevaswom.in", "Guruvayur Devaswom ");
                var subject = sub;
                var to = new EmailAddress(Recipient, "");
                var PlainTextContent = "Hi,<br> Greetings! <br>" + body + "<br>Best Regards, <br>  Guruvayur Devaswom ";
                var HtmlContent = "Hi,<br> Greetings! <br>" + body + "<br>Best Regards, <br>  Guruvayur Devaswom";
                var msg = MailHelper.CreateSingleEmail(from, to, subject, PlainTextContent, HtmlContent);
                var response = client.SendEmailAsync(msg);
                return true;
                //var Recipient = toMail;
                //var apiKey = "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";
                //var client = new SendGridClient(apiKey);
                ////var msg = new SendGridMessage()
                ////{
                //   From = new EmailAddress("info@malliyoortemple.com", "Malliyoor Temple"),
                //    Subject = sub,
                //    PlainTextContent = "Hi,<br> Greetings! <br>" + body + "<br>Best Regards, <br>  Malliyoor Sree Maha Ganapathy Temple",
                //   HtmlContent = "Hi,<br> Greetings! <br>" + body + "<br>Best Regards, <br>  Malliyoor Sree Maha Ganapathy Temple",
                //    var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                //var response = client.SendEmailAsync(msg);
                //return true;
                //   Personalizations = new List<Personalization>
                //  {
                //  new Personalization
                //  {
                //  Tos = new List<EmailAddress>
                //   {
                //   new EmailAddress(toMail, ""),

                //   },
                //  Ccs=new List<EmailAddress>
                //  {
                //       //new EmailAddress("akhilavallath@gmail.com", "")
                //  }
                //}
                //  }
                //};

                //var response = client.SendEmailAsync(msg);
                // return true;
                //var from = new EmailAddress("info@vallathtemple.com", "Vallath Temple");
                //var subject = sub;
                //var to = new EmailAddress(Recipient, "");

                //var plainTextContent = "Hi,<br> Greetings! <br>" + body + "<br>Best Regards, <br>  Vallath Sree Bhagavathy Temple";
                //var htmlContent = "Hi,<br> Greetings! <br>" + body + "<br>Best Regards, <br>  Vallath Sree Bhagavathy Temple";
                //var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                //var response = client.SendEmailAsync(msg);

            }
            catch (Exception e)
            {

                return true;
            }
        }*/

    }
}
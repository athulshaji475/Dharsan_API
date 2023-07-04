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
    public class GuestHomeController : ApiController
    {
        Guruvayur_VisitEntities obj = new Guruvayur_VisitEntities();

        //Inserting The guest user
        [HttpPost]
        public IEnumerable<InsertVisiterByLink_Result> InsertVisiterByLink(Viewers v)
        {
            try
            {
                return obj.InsertVisiterByLink(v.MId, v.TsId, v.GId, v.VisiterName, v.VisiterMobile, v.VisiterPlace, v.PDate, v.Enterdon, v.PrintedOn, v.Status, v.EnterdBy, v.NoOfP, v.Remarks, v.Linkid);

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }





        [HttpGet]
        public IEnumerable<GetViviterByLinkAddress_Result> GetViviterByLinkAddress(Guid Linkid)
        {
            try
            {
                return (obj.GetViviterByLinkAddress(Linkid));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}


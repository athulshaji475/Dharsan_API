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
    public class UpdateLinkUserController : ApiController
    {
        Guruvayur_VisitEntities obj = new Guruvayur_VisitEntities();
        [HttpPost]
        public IEnumerable<UpdateLinuser_Result> UpdateVisiterByLink(Viewers v)
        {
            return (obj.UpdateLinuser(v.TsId,v.VisiterName, v.VisiterMobile, v.VisiterPlace, v.PDate, v.PrintedOn, v.NoOfP, v.Remarks, v.Linkid));
        }

    }
}

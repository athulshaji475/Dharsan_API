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
    public class SettingsController : ApiController
    {
        Guruvayur_VisitEntities obj = new Guruvayur_VisitEntities();
        [HttpGet]
        public IEnumerable<GetInitSettings_Result> GetInitSettings()
        {
            try
            {
                return (obj.GetInitSettings());
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}

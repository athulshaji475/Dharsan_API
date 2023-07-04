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
    public class ViewerController : ApiController
    {
        Guruvayur_VisitEntities obj = new Guruvayur_VisitEntities();


        //-------------insert the visiters-----------------

        [HttpPost]
        public IEnumerable<InsertVisiter_Result> SetViewers(Viewers vs)
        {
            try
            {
                return (obj.InsertVisiter(vs.MId, vs.TsId, vs.GId, vs.VisiterName, vs.VisiterMobile, vs.VisiterPlace, vs.Enterdon, vs.PDate, vs.PrintedOn, vs.Status, vs.EnterdBy, vs.NoOfP, vs.Remarks));
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        //--------------------Get Visiters---------------------------


        [HttpGet]

        public List<GetViwersListForApprove_Result> GetViewersList(int sltid)
        {
            List<GetViwersListForApprove_Result> results = new List<GetViwersListForApprove_Result>();
            results = obj.GetViwersListForApprove(sltid).ToList();
            return results;
        }
        //get individual visiters list----------------------------------------------------------------


        [HttpGet]

        public List<GetViwersListForApprove_Individuals_Result> GetViewers_Individual_Result(int Staffid)
        {
            try
            {
                List<GetViwersListForApprove_Individuals_Result> Result = new List<GetViwersListForApprove_Individuals_Result>();
                Result = obj.GetViwersListForApprove_Individuals(Staffid).ToList();
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpGet]

        public IEnumerable<GetViwersListForApprove_Individuals_ByLink_Result> GetViwersListForApprove_Individuals_ByLink(int stid)
        {
            try
            {
                return (obj.GetViwersListForApprove_Individuals_ByLink(stid));

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }




        //----------------------------update status while deleteing--------------
        [HttpPost]
        public IEnumerable<Update_Visiters_Status_Result> Updatestatus_delete(int Vid_delete)
        {
            try
            {
                return (obj.Update_Visiters_Status(3, Vid_delete));
            }
            catch (Exception ex)
            {
                // return null;
                throw ex;
            }
        }

        //-------------------------update status while printing-----------
        [HttpPost]
        public IEnumerable<Update_Visiters_Status_Result> Updatestatus_TobePrint(int Vid_tobeprint)
        {
            try
            {
                return (obj.Update_Visiters_Status(1, Vid_tobeprint));
            }
            catch (Exception ex)
            {
                throw ex;
                //return null;
            }
        }


        [HttpPost]
        public IEnumerable<Approved_ByStaff_ToAdmin_Result> Approved_ByStaff_ToAdmin_Result(int vid_to_admin)
        {
            try
            {
                return (obj.Approved_ByStaff_ToAdmin(vid_to_admin));
            }
            catch(Exception ex)

            {
                throw ex;
            }        }





    }
}

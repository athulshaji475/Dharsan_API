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
    public class ManagementController : ApiController
    {
        
            Guruvayur_VisitEntities obj = new Guruvayur_VisitEntities();


            [HttpGet]
            public IEnumerable<GetGate_Result> GetGates()
            {
                try
                {
                    return (obj.GetGate());
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            [HttpGet]
            public IList<GetManagement_Result> GetManagement(int d)
            {
                try
                {
                    List<GetManagement_Result> result = new List<GetManagement_Result>();
                    result = obj.GetManagement().ToList();
                    return (result);

                }
                catch (Exception ex)
                {
                    return null;
                }
            }

            //get management


            //Get timesolat
            [HttpGet]
            public IEnumerable<GetTimeSloat_Result> GetTimesloat(int dummyid)
            {
                try
                {
                    return (obj.GetTimeSloat());
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            //fetching the datas of management staffs
            [HttpGet]
            public IList<GetManagementData_Result> CheckStaffExist(String mnum)
            {
                try
                {
                    List<GetManagementData_Result> Result = new List<GetManagementData_Result>();
                    Result = obj.GetManagementData(mnum).ToList();
                    if (Result.Count > 0)
                    {
                        return Result;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }

            }
        [HttpGet]
        public IList<GetManagementTotalLimitsPerDay_Result>GetTotalsOfLimitperDay(int Id,DateTime date)
        {
            try
            {
                List<GetManagementTotalLimitsPerDay_Result> Result = new List<GetManagementTotalLimitsPerDay_Result>();
                Result = obj.GetManagementTotalLimitsPerDay(Id, date).ToList();
                if(Result.Count>0)
                {
                    return Result;

                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                throw ex;
                    }
        }

        }
    }

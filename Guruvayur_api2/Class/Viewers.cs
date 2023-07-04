using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Guruvayur_api2.Class
{
    public class Viewers
    {
        public int MId { get; set; }
        public int TsId { get; set; }
        public int GId { get; set; }
        public string VisiterName { get; set; }
        public string VisiterMobile { get; set; }
        public string VisiterPlace { get; set; }
        public DateTime Enterdon { get; set; }
        public DateTime PDate { get; set; }
        public DateTime PrintedOn { get; set; }
        public int Status { get; set; }
        public int EnterdBy { get; set; }
        public int NoOfP { get; set; }
        public String Remarks { get; set; }
        public Guid Linkid { get; set; }
    }
}
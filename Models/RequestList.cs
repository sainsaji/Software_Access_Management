using System;

namespace File_Acess_Management
{
    public class RequestList
    {
        public int requestId { get; set; }
        public int userId { get; set; }
        public string manApproval { get; set; }
        public string admApproval { get; set; }
        public string status { get; set; }
        public int softId { get; set; }
        public string userRemark { get; set; }
        public string managerRemark { get; set; }
        public string adminRemark { get; set; }
        public DateTime dateTime { get; set;}
    }
}
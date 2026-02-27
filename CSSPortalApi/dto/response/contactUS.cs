using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSPortalApi.Entities
{
    public class ContactUs
    {
        public int contactUSID { get; set; }
        public string userName { get; set; }
        public string email { get; set; }
        public string contact { get; set; }
        public string userMessage { get; set; }
        public string createdOn { get; set; }
        public bool readMsg { get; set; }
    }
}
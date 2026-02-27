using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSPortalApi.Entities
{
    public class ContactUsCreation
    {
        public int contactUSID { get; set; }
        public string userName { get; set; }
        public string email { get; set; }
        public string contact { get; set; }
        public string subject { get; set; }
        public string userMessage { get; set; }
        public int userID { get; set; }
        public string spType { get; set; }
    }
}
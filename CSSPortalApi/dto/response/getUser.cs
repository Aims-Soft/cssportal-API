using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSPortalApi.Entities
{
    public class GetUser
    {
        public int userID { get; set; }
        public string userName { get; set; }
        public int sessionID { get; set; }
        public int isPresent { get; set; }
   }
}
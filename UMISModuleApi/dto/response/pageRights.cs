using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UMISModuleAPI.Entities
{
    public class pageRights{
        public string routeTitle { get; set; }
        public int userID { get; set; }
        public int read { get; set; }
        public int write { get; set; }
        public int delete { get; set; }
    }
}
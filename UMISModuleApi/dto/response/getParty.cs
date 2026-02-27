using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UMISModuleApi.dto.response
{
    public class GetParty
    {
        public int partyID { get; set; }
        public string partyName { get; set; }
        public string partyCNIC { get; set; }
        public int userID { get; set; }
        public string CNIC { get; set; }
    }
}
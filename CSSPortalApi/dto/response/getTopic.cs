
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSPortalApi.Entities
{
    public class GetTopic
    {
        public int TopicID { get; set; }
        public string TopicTitle { get; set; }
        public int SubjectID { get; set; }
    }
}
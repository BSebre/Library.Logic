using NewsLogic.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsWeb.Models
{
    public class TopicsModel
    {
        public List<Topic> Topics { get; set; }

        public List<Article> Articles { get; set; }

        public Topic ActiveTopics { get; set; }

    }
}

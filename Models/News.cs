using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newsbr.Models
{
    public class News
    {
        public string status { get; set; }
        public int totalresults { get; set; }
        public IList<Articles> Articles { get; set; }
        public News()
        {

        }

    }
}

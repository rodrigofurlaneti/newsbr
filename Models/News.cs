using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newsbr.Models
{
    public class News
    {
        public string Status { get; set; }
        public int TotalResults { get; set; }
        public IList<Articles> Articles { get; set; }
        public News()
        {
        }
        public News(string Status, int TotalResults, IList<Articles> Articles)
        {
            this.Status = Status;
            this.TotalResults = TotalResults;
            this.Articles = Articles;
        }

    }
}

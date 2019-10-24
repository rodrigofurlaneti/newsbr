﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newsbr.Models
{
    public class Articles
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string UrlToImage { get; set; }
        public string Url { get; set; }
        public DateTime PublishedAt { get; set; }
    }
}

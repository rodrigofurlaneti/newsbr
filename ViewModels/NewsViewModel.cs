using newsbr.Models;
using System;
using System.Collections.Generic;

namespace newsbr.ViewModels
{
    public class NewsViewModel
    {
        public List<News> ListaNews { get; set; }

        public NewsViewModel()
        {
            List<News> ListaNews = new List<News>();
        }
    }
}

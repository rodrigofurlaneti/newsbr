using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using newsbr.Models;
using Newtonsoft.Json;

namespace newsbr.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string ApiBaseUrl = "https://newsapi.org/v2/top-headlines?country=br&apiKey=f379e5691f5a4fd3b601a6990e0c4a14"; // endereço da sua api
            //string MetodoPath = "News/GetTodosNews"; //caminho do método a ser chamado

            var news = new News();
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(ApiBaseUrl);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var body = streamReader.ReadToEnd();
                    News retorno = JsonConvert.DeserializeObject<News>(body);
                    if (retorno != null)
                        news.status = retorno.status;
                        news.totalresults = retorno.totalresults;
                        news.Articles = retorno.Articles;
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return View(news);
        }
    }
}

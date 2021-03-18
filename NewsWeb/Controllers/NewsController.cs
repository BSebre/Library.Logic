using Microsoft.AspNetCore.Mvc;
using NewsLogic;
using NewsLogic.Manager;
using NewsWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsWeb.Controllers
{
    public class NewsController : Controller
    {
        private TopicManager topics = new TopicManager();
        private NewsManager articles = new NewsManager();
        public IActionResult Topic(int? id)
        {
            TopicsModel model = new TopicsModel();
            model.Topics = topics.GetAllTopics();
            if (id.HasValue)
            { 
                // retrieve articles
                model.ActiveTopics = topics.GetTopic(id.Value);
                // retrvve active topic info
                model.Articles = articles.GetByTopic(id.Value);
            }

            return View(model);
        }
        public IActionResult Article(int? id)
        {
            //if (id.HasValue)
            //{

            //}
            return View();
        }
    }
}

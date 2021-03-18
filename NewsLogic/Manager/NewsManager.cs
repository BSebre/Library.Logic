using NewsLogic.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsLogic.Manager
{
    public class NewsManager
    {
        public List<Article> GetLatestNews(int count = 6)
        {
            using (var db = new NewsDB())
            {
                return db.Articles.OrderByDescending(a => a.PublishedOn).Take(count).ToList();
            }
        }

        public List<Article> GetByTopic(int topicId)
        {
            using (var db = new NewsDB())
            {
                return db.Articles.Where(a => a.TopicId == topicId)
                    .OrderByDescending(a => a.PublishedOn)
                    .ToList();
            }
        }
        public Article GetById(int id)
        {
            using (var db = new NewsDB())
            {
                return db.Articles.FirstOrDefault(a => a.Id == id);
            }
        }
    }
}

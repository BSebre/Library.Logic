using NewsLogic.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsLogic
{
    public class TopicManager
    {

        public List<Topic> GetAllTopics()
        {
            //returns Topics, ordered by Title ASC
            using (var db = new NewsDB())
            {
                // SELECT * FROM Topics ORDER BY Title
                return db.Topics.OrderBy(t => t.Title).ToList();
            }
        }
        public Topic GetTopic(int id)
        {
            using(var db = new NewsDB())
            {
                return db.Topics.FirstOrDefault(t => t.Id == id);
            }
        }

        public string CreateNew(string title)
        {
            using (var db = new NewsDB())
            {
                if (String.IsNullOrEmpty(title))
                {
                    throw new LogicException("Title can't be empty!");
                }
                // 1. Topic title should be unique
                var sameTitle = db.Topics.FirstOrDefault(t => t.Title.ToLower() == title.ToLower());
                if (sameTitle != null)
                {
                    throw new LogicException("Topic already exists!");
                }

                db.Topics.Add(new Topic()
                {
                    Title = title, 

                });

                db.SaveChanges();

                return null;
            }
        }
    }
}

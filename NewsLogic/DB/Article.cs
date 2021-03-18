using System;
using System.Collections.Generic;

#nullable disable

namespace NewsLogic.DB
{
    public partial class Article
    {
        public int Id { get; set; }
        public int TopicId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime PublishedOn { get; set; }
        public string Image { get; set; }
        public string Author { get; set; }
    }
}

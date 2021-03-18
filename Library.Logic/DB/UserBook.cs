using System;
using System.Collections.Generic;

#nullable disable

namespace Library.Logic.DB
{
    public partial class UserBook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Author { get; set; }
    }
}

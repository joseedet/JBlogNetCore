using System;
using System.Collections.Generic;
using System.Text;

namespace BlogEngine.DataModel.Entities
{
   public class Post:BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}

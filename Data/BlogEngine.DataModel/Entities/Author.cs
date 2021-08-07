using System;
using System.Collections.Generic;
using System.Text;

namespace BlogEngine.DataModel.Entities
{
    public class Author:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

    }
}

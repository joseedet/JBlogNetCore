using System;
using System.Collections.Generic;
using System.Text;

namespace BlogEngine.DataModel.Entities
{
    public class BaseEntity
    {
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime? UpdateOn { get; set; }
        public bool IsActive { get; set; }
        public DateTime? DeletedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}

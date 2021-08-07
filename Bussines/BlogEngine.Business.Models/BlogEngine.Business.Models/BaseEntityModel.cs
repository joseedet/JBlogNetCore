using System;
using System.Collections.Generic;
using System.Text;

namespace BlogEngine.Business.Models
{
    public class BaseEntityModel
    {
        public DateTime CreatedOn { get; set; }
        public DateTime UpdateOn { get; set; }
        public bool IsActive { get; set; }
        public DateTime? DeletedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}

using BlogEngine.DataModel.Enum;

using System;
using System.Collections.Generic;
using System.Text;

namespace BlogEngine.Business.Models
{
    public class PromptModel:BaseEntityModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public PromptType PromptType { get; set; }
    }
}

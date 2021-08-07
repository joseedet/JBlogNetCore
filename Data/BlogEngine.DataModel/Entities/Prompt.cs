using BlogEngine.DataModel.Enum;

namespace BlogEngine.DataModel.Entities
{
    public class Prompt:BaseEntity
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public PromptType PromptType { get; set; }
    }
}

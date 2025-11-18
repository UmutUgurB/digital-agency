namespace digitalAgency.Application.Dtos.Comments
{
    public class CommentVm
    {
        public Guid Id { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public bool IsShown { get; set; }
    }
}

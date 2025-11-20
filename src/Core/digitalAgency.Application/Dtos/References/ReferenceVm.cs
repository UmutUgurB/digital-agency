namespace digitalAgency.Application.Dtos.References
{
    public class ReferenceVm
    {
        public Guid Id { get; set; }    
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
        public bool IsShown { get; set; }
    }
}

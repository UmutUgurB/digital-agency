namespace digitalAgency.Application.Dtos.Contacts
{
    public class ContactVm
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public bool IsActive { get; set; } = true;
    }
}

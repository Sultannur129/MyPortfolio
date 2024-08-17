namespace MyPortfolio.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }


    public class GetLogin
    {

        public string? username { get; set; }
        public string? password { get; set; }
    }

    public class Message1
    {
        public string? NameSurname { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
        public string MessageDetail { get; set; }
        public DateTime SendDate { get; set; }
        public bool IsRead { get; set; }
    }
}
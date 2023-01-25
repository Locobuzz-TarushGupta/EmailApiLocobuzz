namespace EmailApiLocobuzz.Models
{
    public class EmailDetails
    {
       // public string From { get; set; }    
        public string EmailAddress { get; set; }  = string.Empty;
        public string? Subject { get; set; } = string.Empty;
        public string Body { get; set; }
        public IEnumerable<EmailAttachment>? Attachments { get; set; }
    }
}

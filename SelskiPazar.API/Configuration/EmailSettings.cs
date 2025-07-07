namespace SelskiPazar.API.Configuration
{
    public class EmailSettings
    {
        public const string SectionName = "Email";

        public string Provider { get; set; } = "SendGrid";
        public string ApiKey { get; set; } = string.Empty;
        public string FromEmail { get; set; } = string.Empty;
        public string FromName { get; set; } = string.Empty;
    }
}

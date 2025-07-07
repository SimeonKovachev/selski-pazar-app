namespace SelskiPazar.API.Configuration
{
    public class FileStorageSettings
    {
        public const string SectionName = "FileStorage";

        public string Provider { get; set; } = "Local";
        public string UploadPath { get; set; } = "wwwroot/uploads";
        public long MaxFileSize { get; set; } = 5242880; // 5MB
        public string[] AllowedFileTypes { get; set; } = { "image/jpeg", "image/png", "image/webp" };
    }
}

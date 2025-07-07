﻿namespace SelskiPazar.API.Configuration
{
    public class JwtSettings
    {
        public const string SectionName = "JwtSettings";

        public string Secret { get; set; } = string.Empty;
        public string Issuer { get; set; } = string.Empty;
        public string Audience { get; set; } = string.Empty;
        public int ExpiryMinutes { get; set; } = 1440; // 24 hours
        public int RefreshTokenExpiryDays { get; set; } = 7;
    }
}

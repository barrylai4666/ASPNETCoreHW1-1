
//Copy appsettings.json To Clipboard -> VSCode -> F1 -> Paste JSON As Types
namespace ASPNETCoreHW1.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AppSettings
    {
        [JsonProperty("JwtSettings")]
        public JwtSettings JwtSettings { get; set; }

        [JsonProperty("ConnectionStrings")]
        public ConnectionStrings ConnectionStrings { get; set; }

        [JsonProperty("Logging")]
        public Logging Logging { get; set; }

        [JsonProperty("AllowedHosts")]
        public string AllowedHosts { get; set; }
    }

    public partial class ConnectionStrings
    {
        [JsonProperty("CotosouniversityConnection")]
        public string CotosouniversityConnection { get; set; }
    }

    public partial class JwtSettings
    {
        [JsonProperty("Issuer")]
        public string Issuer { get; set; }

        [JsonProperty("SignKey")]
        public string SignKey { get; set; }
    }

    public partial class Logging
    {
        [JsonProperty("LogLevel")]
        public LogLevel LogLevel { get; set; }
    }

    public partial class LogLevel
    {
        [JsonProperty("Default")]
        public string Default { get; set; }

        [JsonProperty("Microsoft")]
        public string Microsoft { get; set; }

        [JsonProperty("MicrosoftHostingLifetime")]
        public string MicrosoftHostingLifetime { get; set; }
    }

}

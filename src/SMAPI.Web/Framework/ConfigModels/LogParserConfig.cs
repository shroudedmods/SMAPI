namespace StardewModdingAPI.Web.Framework.ConfigModels
{
    /// <summary>The config settings for the log parser.</summary>
    internal class LogParserConfig
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The root URL for the log parser controller.</summary>
        public string SectionUrl { get; set; }

        /// <summary>The base URL for the Pastebin API.</summary>
        public string PastebinBaseUrl { get; set; }

        /// <summary>The user agent for the Pastebin API client, where {0} is the SMAPI version.</summary>
        public string PastebinUserAgent { get; set; }

        /// <summary>The user key used to authenticate with the Pastebin API.</summary>
        public string PastebinUserKey { get; set; }

        /// <summary>The developer key used to authenticate with the Pastebin API.</summary>
        public string PastebinDevKey { get; set; }
    }
}

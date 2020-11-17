using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.Json.Serialization;

namespace GandiClient.Requests
{
    public class GetDomainAvailabilityRequest
    {
        /// <summary>
        /// domain name to query
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// ISO country code for which taxes are to be applied
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; }

        /// <summary>
        /// request price for a specific ISO currency code
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; }

        /// <summary>
        /// list of at least 1 process for which pricing is to be made
        /// </summary
        [JsonPropertyName("duration_unit")]
        public string DurationUnit { get; }

        /// <summary>
        /// query a specific extension for product options
        /// </summary>
        [JsonPropertyName("extension")]
        public string Extension { get; }

        /// <summary>
        /// request price for a specific rate
        /// </summary>
        [JsonPropertyName("grid")]
        public string Grid { get; }

        /// <summary>
        /// language code
        /// </summary>
        [JsonPropertyName("lang")]
        public string Lang { get; }

        /// <summary>
        /// set a limit on the duration range for returned prices
        /// </summary>
        [JsonPropertyName("max_duration")]
        public int? MaxDuration { get; }

        /// <summary>
        /// specific registration period to query
        /// </summary>
        [JsonPropertyName("period")]
        public string Period { get; }

        /// <summary>
        /// list of at least 1 process for which pricing is to be made
        /// </summary>
        [JsonPropertyName("processes")]
        public string[]? Processes { get; }

        /// <summary>
        /// Organization for which the pricing is to be made. See the <see href="https://api.gandi.net/docs/reference/#Sharing-ID">reference</see>.
        /// </summary>
        [JsonPropertyName("sharing_i")]
        public string SharingId { get; }
    }
}

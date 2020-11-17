using System;
using System.Collections.Generic;
using System.Text;

namespace GandiClient.Responses
{
    public class GetDomainAvailabilityResponse
    {
        public string Currency { get; }
        public string Grid { get; }
    }

    public class Product
    {
        string Name { get; }
    }
    public class Price
    {
        public string DurationUnit { get; }
        public int MaxDuration { get; }
        public int MinDuration { get; }
        public decimal PriceAfterTaxes { get; }
        public decimal PriceBeforeTaxes { get; }
    }

    public enum ProductStatus
    {
        /// <summary>
        /// Domain name is available
        /// </summary>
        available,
        /// <summary>
        /// Domain name reserved under special conditions
        /// </summary>
        available_reserved,
        available_preorder,
        unavailable,
        unavailable_premium,
        unavailable_restricted,
        error_invalid,
        error_refused,
        error_timeout,
        error_unknown,
        reserved_corporate,
        pending,
        error_eoi
    }
}

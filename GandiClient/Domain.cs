using GandiClient.Abstractions;
using GandiClient.Requests;
using GandiClient.Responses;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Authentication;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GandiClient
{
    public class Domain : IDomain
    {
        private readonly HttpClient httpClient;

        public Task CreateDomain()
        {
            throw new NotImplementedException();
        }

        public Task CreateGlueRecord()
        {
            throw new NotImplementedException();
        }

        public Task DeleteGlueRecord()
        {
            throw new NotImplementedException();
        }

        public Task EditAutoRenewStatus()
        {
            throw new NotImplementedException();
        }

        public Task EnableLiveDNS()
        {
            throw new NotImplementedException();
        }

        public async Task<GetDomainAvailabilityResponse> GetDomainAvailability(GetDomainAvailabilityRequest request)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append($"?name={request.Name}");

            if (!string.IsNullOrEmpty(request.Country))
                stringBuilder.Append($"country={request.Country}");

            if (!string.IsNullOrEmpty(request.Currency))
                stringBuilder.Append($"currency={request.Currency}");

            if (!string.IsNullOrEmpty(request.DurationUnit))
                stringBuilder.Append($"duration_unit={request.DurationUnit}");

            if (!string.IsNullOrEmpty(request.Extension))
                stringBuilder.Append($"extension={request.Extension}");

            if (!string.IsNullOrEmpty(request.Grid))
                stringBuilder.Append($"grid={request.Grid}");

            if (!string.IsNullOrEmpty(request.Lang))
                stringBuilder.Append($"lang={request.Lang}");

            if (!request.MaxDuration.HasValue)
                stringBuilder.Append($"max_duration={request.MaxDuration.Value}");

            if (!string.IsNullOrEmpty(request.Period))
                stringBuilder.Append($"period={request.Period}");

            var response = await httpClient.GetAsync(stringBuilder.ToString());

            var stream = await response.Content.ReadAsStreamAsync();

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return await JsonSerializer.DeserializeAsync<GetDomainAvailabilityResponse>(stream);

            if (response.StatusCode == System.Net.HttpStatusCode.Forbidden || response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                var error = await JsonSerializer.DeserializeAsync<AuthError>(stream);
                throw new AuthenticationException($"Auth exception {error.Cause} {error.Message}");
            }

            throw new Exception($"Http exception {response.StatusCode}");
        }

        public Task GetDomainContactList()
        {
            throw new NotImplementedException();
        }

        public Task GetDomainDetails()
        {
            throw new NotImplementedException();
        }

        public Task GetGlueRecord()
        {
            throw new NotImplementedException();
        }

        public Task GetGlueRecordList()
        {
            throw new NotImplementedException();
        }

        public Task GetLiveDNSInformation()
        {
            throw new NotImplementedException();
        }

        public Task ListDomains()
        {
            throw new NotImplementedException();
        }

        public Task UpdateDomainContact()
        {
            throw new NotImplementedException();
        }

        public Task UpdateGlueRecord()
        {
            throw new NotImplementedException();
        }
    }
}

using GandiClient.Requests;
using GandiClient.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GandiClient.Abstractions
{
    public interface IDomain
    {
        Task<GetDomainAvailabilityResponse> GetDomainAvailability(GetDomainAvailabilityRequest request);
        Task ListDomains();
        Task CreateDomain();
        Task GetDomainDetails();
        Task EditAutoRenewStatus();
        Task GetDomainContactList();
        Task UpdateDomainContact();
        Task GetGlueRecordList();
        Task CreateGlueRecord();
        Task GetGlueRecord();
        Task UpdateGlueRecord();
        Task DeleteGlueRecord();
        Task GetLiveDNSInformation();
        Task EnableLiveDNS();

    }
    public interface ILiveDNS
    {

    }
    public interface IEmail
    {

    }
    public interface IBilling
    {

    }

    public interface IOrganisation
    {

    }
}

using System.Collections.Generic;
using Abp.Application.Services.Dto;
using project56.Editions.Dto;

namespace project56.MultiTenancy.Dto
{
    public class GetTenantFeaturesForEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}
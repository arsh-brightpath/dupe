using Abp.Application.Services;
using Abp.Application.Services.Dto;
using project56.Persons.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project56.Persons
{
    public interface IPersonAppService : IApplicationService
    {
        ListResultDto<PersonListDto> GetPeople(GetPeopleInput input);
        Task CreatePerson(CreatePersonInput input);
        Task DeletePerson(EntityDto input);
    }
}

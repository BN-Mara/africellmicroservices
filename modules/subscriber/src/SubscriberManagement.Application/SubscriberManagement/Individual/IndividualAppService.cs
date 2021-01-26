using Microsoft.AspNetCore.Authorization;
using SubscriberManagement.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Authorization;
using Volo.Abp.Domain.Repositories;

namespace SubscriberManagement
{ 
    public class IndividualAppService:CrudAppService<Individual,SubscriberDto,Guid,IndividualGetListInput,IndividualInput>,IIndividualAppService
    {
        public IndividualAppService(IRepository<Individual,Guid> repo):base(repo){
            CreatePolicyName = SubscriberManagementPermissions.Individuals.Create;
            UpdatePolicyName= SubscriberManagementPermissions.Individuals.Update;
            DeletePolicyName= SubscriberManagementPermissions.Individuals.Delete;
           
        }
        [Authorize(SubscriberManagementPermissions.Individuals.Verify)]
        public async Task<SubscriberDto> Check(Guid Id, bool valid)
        {
            var input= await Repository.GetAsync(Id);
            if (input == null) new SubscriberNotExistingException();
            input.IsVerified = valid;
            input.Validator = CurrentUser.Id;
            input.VerifiedDate = Clock.Now;
            var dto = await Repository.UpdateAsync(input);
            return MapToGetOutputDto(dto);
        }

        [Authorize(SubscriberManagementPermissions.Individuals.Create)]
        public override async Task<SubscriberDto> CreateAsync(IndividualInput input)
        {
            Individual individual = await Repository.InsertAsync(
                  new Individual(
                          GuidGenerator.Create(),
                          input.PhoneNumber,
                          input.Firstname,
                          input.LastName,
                          input.BirthDate,
                          input.Address,
                          input.Gender,
                          input.Nationality,
                          input.IDType,
                          input.IDRef,
                          input.IDImage,
                          input.IDDeliveryDate,
                          input.IDExpireDate,
                          input.MiddleName,
                          input.PersonImage,
                          input.ICCID
                      )
                  { CreationTime = Clock.Now }) ;
            return MapToGetOutputDto(individual);
        }

        public  async Task<ListResultDto<SubscriberDto>> GetListAsync()
        {
            var result = await AuthorizationService
                              .AuthorizeAsync(SubscriberManagementPermissions.Individuals.ViewAll);
            List<Individual> individuals;
            if (result.Succeeded) individuals = await Repository.GetListAsync();
            else individuals = Repository.Where(c => c.CreatorId == CurrentUser.Id.Value).ToList();

            var individualList = ObjectMapper.Map<List<Individual>, List<SubscriberDto>>(individuals);
            return new ListResultDto<SubscriberDto>(individualList);
        }

        public override async Task<PagedResultDto<SubscriberDto>> GetListAsync(IndividualGetListInput input)
        {
            var result = await AuthorizationService
                            .AuthorizeAsync(SubscriberManagementPermissions.Individuals.ViewAll);
            Guid? userId = this.CurrentUser.Id;
            if (!result.Succeeded) {
                if (userId.HasValue) input.CreatedBy = userId.Value;
                else throw new AbpAuthorizationException();
            }
           
            return await base.GetListAsync(input);
        }

        protected override IQueryable<Individual> CreateFilteredQuery(IndividualGetListInput input)
        {
            return base.CreateFilteredQuery(input)
                .WhereIf(input.Validator.HasValue, c => c.Validator == input.Validator.Value)
                .WhereIf(input.VerifiedDate.HasValue, c => c.VerifiedDate.Value.Date.Equals(input.VerifiedDate.Value.Date))
                .WhereIf(input.IsValidated.HasValue, c => c.IsValidated.Value == input.IsValidated.Value)
                .WhereIf(input.CreatedBy.HasValue, c => c.CreatorId.Value == input.CreatedBy.Value)
                .WhereIf(input.Gender.HasValue,c=>c.Gender==input.Gender.Value)
                .WhereIf(input.IDType.HasValue,c=>c.IDType==input.IDType.Value)
                .WhereIf(input.Nationality!=null,c=>c.Nationality==input.Nationality);
        }
    }
}

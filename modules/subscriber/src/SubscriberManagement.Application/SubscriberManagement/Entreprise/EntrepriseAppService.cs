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
using Volo.Abp.Timing;

namespace SubscriberManagement
{
    public  class EntrepriseAppService:CrudAppService<Entreprise,SubscriberDto,Guid,EntrepriseGetListInput,EntrepriseInput>,
             IEntrepriseAppService
    {
        
        public EntrepriseAppService(IRepository<Entreprise,Guid> repo):base(repo)
        {
            
        }

        [Authorize(SubscriberManagementPermissions.Entreprises.Verify)]
        public async Task<SubscriberDto> Check(Guid Id, bool valid)
        {
            var input = await Repository.GetAsync(Id);
            if (input == null) new SubscriberNotExistingException();
            input.IsVerified = valid;
            input.Validator = CurrentUser.Id;
            input.VerifiedDate = Clock.Now;
            var dto = await Repository.UpdateAsync(input);
            return MapToGetOutputDto(dto);
        }

        public override async Task<SubscriberDto> CreateAsync(EntrepriseInput input)
        {
              bool registered = Repository.Any(c => c.PhoneNumber == input.PhoneNumber && c.ExpiryDate == null);
              if (registered) throw new SubscriberAlreadyRegisteredException(input.PhoneNumber);
              Entreprise entreprise= await  Repository.InsertAsync(new Entreprise(
                            GuidGenerator.Create(),
                            input.PhoneNumber,
                            input.NationalId,
                            input.EntrepriseName,
                            input.Responsible,
                            input.LegalForm,
                            input.Address,
                            initialICCID: input.ICCID
                    )
              { CreationTime=Clock.Now});

                return MapToGetOutputDto(entreprise);
        }
        public override async Task<PagedResultDto<SubscriberDto>> GetListAsync(EntrepriseGetListInput input)
        {
            var result = await AuthorizationService
                            .AuthorizeAsync(SubscriberManagementPermissions.Entreprises.ViewAll);
            Guid? userId = this.CurrentUser.Id;
            if (!result.Succeeded)
            {
                if (userId.HasValue) input.CreatedBy = userId.Value;
                else throw new AbpAuthorizationException();
            }

            return await base.GetListAsync(input);
        }
        public async Task<ListResultDto<SubscriberDto>> GetListAsync()
        {
            var result = await AuthorizationService
                              .AuthorizeAsync(SubscriberManagementPermissions.Entreprises.ViewAll);
            List<Entreprise> entreprises;
            if (result.Succeeded) entreprises = await Repository.GetListAsync();
            else entreprises = Repository.Where(c => c.CreatorId == CurrentUser.Id.Value).ToList();

            var entrepriseList = ObjectMapper.Map<List<Entreprise>, List<SubscriberDto>>(entreprises);
            return new ListResultDto<SubscriberDto>(entrepriseList);
        }

        protected override IQueryable<Entreprise> CreateFilteredQuery(EntrepriseGetListInput input)
        {
            return base.CreateFilteredQuery(input)
                .WhereIf(input.Validator.HasValue,c=>c.Validator==input.Validator.Value)
                .WhereIf(input.VerifiedDate.HasValue,c=>c.VerifiedDate.Value.Date.Equals(input.VerifiedDate.Value.Date))
                .WhereIf(input.IsValidated.HasValue,c=>c.IsValidated.Value==input.IsValidated.Value)
                .WhereIf(input.CreatedBy.HasValue,c=>c.CreatorId.Value==input.CreatedBy.Value)
                .WhereIf(input.LegalForm==null,c=>c.LegalForm==input.LegalForm);
        }
    }
}

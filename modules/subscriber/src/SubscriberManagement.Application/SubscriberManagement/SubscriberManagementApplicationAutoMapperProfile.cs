using AutoMapper;
using System.Collections;
using System.Collections.Generic;
using Volo.Abp.AutoMapper;

namespace SubscriberManagement
{
    public class SubscriberManagementApplicationAutoMapperProfile : Profile
    {
        public SubscriberManagementApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            
            CreateMap<Individual, SubscriberDto>()
                .ForMember(dest => dest.NationalId,opt=>opt.Ignore())
                .ForMember(dest => dest.EntrepriseName, opt => opt.Ignore())
                .ForMember(dest => dest.Responsible, opt => opt.Ignore())
                .ForMember(dest => dest.LegalForm,opt=>opt.Ignore())
                .ForMember(dest => dest.Name, opt => opt.MapFrom(c => c.Firstname + " " + c.Lastname));
            CreateMap<Entreprise, SubscriberDto>()
                .ForMember(dest => dest.Firstname, opt => opt.Ignore())
                .ForMember(dest => dest.Lastname, opt => opt.Ignore())
                .ForMember(dest => dest.Middlename, opt => opt.Ignore())
                .ForMember(dest => dest.BirthDate, opt => opt.Ignore())
                .ForMember(dest => dest.PersonImage, opt => opt.Ignore())
                .ForMember(dest => dest.Gender, opt => opt.Ignore())
                .ForMember(dest => dest.IDType, opt => opt.Ignore())
                .ForMember(dest => dest.IDRef, opt => opt.Ignore())
                .ForMember(dest => dest.IDImage, opt => opt.Ignore())
                .ForMember(dest => dest.IDDeliveryDate, opt => opt.Ignore())
                .ForMember(dest => dest.IDExpireDate, opt => opt.Ignore())
                .ForMember(dest => dest.Nationality,opt=>opt.Ignore())
                .ForMember(dest => dest.Name, opt => opt.MapFrom(c => c.EntrepriseName));
                
            CreateMap<EntrepriseInput, Entreprise>()
              .Ignore(c => c.Id)
              .Ignore(c => c.ExtraProperties)
              .Ignore(c => c.ConcurrencyStamp)
              .Ignore(c => c.InitialICCID)
             .Ignore(c => c.CurrentICCID)
             .Ignore(c => c.ActivationDate)
             .Ignore(c => c.ExpiryDate)
             .Ignore(c => c.VerifiedDate)
             .Ignore(c => c.IsValidated)
             .Ignore(c => c.IsVerified)
             .Ignore(c => c.Validator)
             .Ignore(c => c.Type)
               .IgnoreFullAuditedObjectProperties();
            CreateMap<IndividualInput, Individual>()
              .Ignore(c=>c.Id)
             .Ignore(c => c.ExtraProperties)
             .Ignore(c => c.ConcurrencyStamp)
             .Ignore(c => c.InitialICCID)
             .Ignore(c => c.CurrentICCID)
             .Ignore(c => c.ActivationDate)
             .Ignore(c => c.ExpiryDate)
             .Ignore(c => c.VerifiedDate)
             .Ignore(c => c.IsValidated)
             .Ignore(c => c.IsVerified)
             .Ignore(c => c.Validator)
             .Ignore(c => c.Type)
             .IgnoreFullAuditedObjectProperties();
            

        }
    }
}
using Africell.Erp.Shared;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;

namespace SubscriberManagement
{
    public class SubscriberManager:DomainService
    {
        private readonly IRepository<Subscriber, Guid> _subscriberRepository;

        public SubscriberManager(IRepository<Subscriber, Guid> subscriberRepository)
        {
            _subscriberRepository = subscriberRepository;
        }
        //public async Task<Subscriber> CreateAsync( [NotNull] string phoneNumber, [NotNull] string firstName, [NotNull] string lastName, [NotNull] DateTime birthDate, [NotNull] string address,
        //                    [NotNull] Gender gender, [NotNull] string nationality, [NotNull] IDType idType, [NotNull] string idRef, DateTime? activationDate = null, DateTime? expiryDate = null, string idImage = null, DateTime? idDeliveryDate = null,
        //                    DateTime? idExpireDate = null, string middleName = null, string personImage = null, string initialICCID = null, string currentICCID = null) {

            
        //    var existingSubscriber = await _subscriberRepository.FirstOrDefaultAsync(p => p.PhoneNumber == phoneNumber && p.ExpiryDate ==null);
        //    if (existingSubscriber != null)
        //    {
        //        throw new SubscriberAlreadyRegisteredException(phoneNumber);
        //    }
        //    return await _subscriberRepository.InsertAsync(
        //        new Subscriber
        //        ( 
        //             GuidGenerator.Create(),
        //             phoneNumber,
        //             firstName,
        //             lastName,
        //             birthDate,
        //             address,
        //             gender,
        //             nationality,
        //             idType,
        //             idRef,
        //             activationDate,
        //             expiryDate,
        //             idImage,
        //             idDeliveryDate,
        //             idExpireDate,
        //             middleName,
        //             personImage,
        //             initialICCID,
        //             currentICCID

        //        ));   
        //}

        //public async Task<Subscriber> CreateAsync([NotNull] string phoneNumber, [NotNull] string nationalId, [NotNull] string companyName, [NotNull] string responsible, [NotNull] string legalForm,
        //    [NotNull] string address, DateTime? activationDate = null, DateTime? expiryDate = null, string initialICCID = null, string currentICCID = null) {
        //    var existingSubscriber = await _subscriberRepository.FirstOrDefaultAsync(p => p.PhoneNumber == phoneNumber && p.ExpiryDate == null);
        //    if (existingSubscriber != null)
        //    {
        //        throw new SubscriberAlreadyRegisteredException(phoneNumber);
        //    }
        //    return await _subscriberRepository.InsertAsync(
        //        new Subscriber
        //        (
        //            GuidGenerator.Create(),
        //            phoneNumber,
        //            nationalId,
        //            companyName,
        //            responsible,
        //            legalForm,
        //            address,
        //            activationDate,
        //            expiryDate,
        //            initialICCID,
        //            currentICCID
        //            ));
        //}
    }
}

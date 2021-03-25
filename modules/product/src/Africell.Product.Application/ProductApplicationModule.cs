using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using Volo.Abp.Autofac;
using Volo.Abp;
using Africell.Product.Products.Goods;
using Volo.Abp.Domain.Repositories;
using System;
using Africell.Product.Products.Services;

namespace Africell.Product
{
    [DependsOn(
        typeof(ProductDomainModule),
        typeof(ProductApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule),
        typeof(AbpAutofacModule)

        )]
    public class ProductApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<ProductApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<ProductApplicationModule>(validate: true);
            });

           // context.Services.AddDefaultRepository(typeof(Service), typeof(IRepository<Service,Guid>));
                        
        }
    }
}

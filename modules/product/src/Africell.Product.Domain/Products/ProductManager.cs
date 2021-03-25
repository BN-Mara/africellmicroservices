using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;

namespace Africell.Product.Products
{
    public class ProductManager : DomainService
    {
        private   readonly IRepository<Product,Guid> _productRepository;

      

        public ProductManager(IRepository<Product, Guid> productRepository)
        {
            _productRepository = productRepository;
        }
        /*public async Task<Product> CreateAsync(
            
          [NotNull] string code,
          [NotNull] string name,
          ProductType type,
          float price = 0.0f,
          byte[] productImage = null
          
          )
        {
            var existingProduct = await _productRepository.FirstOrDefaultAsync(p => p.Code == code);
            if (existingProduct != null)
            {
                throw new ProductCodeAlreadyExistsException(code);
            }

            return await _productRepository.InsertAsync(
                new Product(
                    GuidGenerator.Create(),
                    code,
                    name,
                    type,
                    price,
                    productImage
                    
                )
            );
        }*/

    }
}

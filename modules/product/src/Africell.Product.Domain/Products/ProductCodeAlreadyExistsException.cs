using System;
using System.Runtime.Serialization;
using Volo.Abp;

namespace Africell.Product.Products
{

    internal class ProductCodeAlreadyExistsException : BusinessException
    {
        public ProductCodeAlreadyExistsException(string productCode)
            : base("PM:000001", $"A product with code {productCode} has already exists!")
        {

        }
    }
}
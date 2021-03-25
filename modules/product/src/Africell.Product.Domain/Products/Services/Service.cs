using Africell.Products;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Africell.Product.Products.Services
{
    public class Service : Product
    {

        public Service()
        {

        }
        public Service(Guid id, [NotNull] string code, [NotNull] string name, ProductType type, ProductCategory category,
           string description, bool livemode, string metadata, byte[] productImage = null)
        {
            SetCode(code);
            SetName(name);
            SetProductImage(productImage);
            Description = description;
            LiveMode = livemode;
            Metadata = metadata;
            Type = type;
            SetCategory(category);
        }

        public Service SetCategory(ProductCategory category)
        {
            if (category != ProductCategory.Service)
            {
                throw new ArgumentException($"Product category is not  correct: {category}");
            }
            Category = category;
            return this;

        }

    
    }
}

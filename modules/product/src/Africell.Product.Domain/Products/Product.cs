using Africell.Products;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace Africell.Product.Products
{
    public class Product :FullAuditedAggregateRoot<Guid>
    {
        [NotNull]
        public virtual string Code { get; set; }
        [NotNull]
        public virtual string Name { get; set; }
        public virtual byte[] ProductImage { get; set; }
        public virtual ProductType Type { get; set; }
        public virtual ProductCategory Category { get; set; }
        public virtual string Description { get; set; }
        public virtual bool LiveMode { get; set; }
        public virtual string Metadata { get; set; }
        public Product()
        {
           
        }
        /*internal Product(Guid id, [NotNull] string code,[NotNull]string name, ProductType type, Category category, string description,bool livemode, string metadata, float price =0.0f, byte[] productImage  = null)
        {
            Check.NotNullOrWhiteSpace(code, nameof(code),ProductConsts.MaxCodeLength, ProductConsts.MinCodeLength );
            if (code.Length >= ProductConsts.MaxCodeLength)
            {
                throw new ArgumentException($"Product code can not be longer than {ProductConsts.MaxCodeLength}");
            }
            Id = id;
            Code = code;
            SetName(Check.NotNullOrWhiteSpace(name, nameof(name)));
            SetPrice(price);
            SetProductImage(productImage);
            Type = type;
            Category =  category;
            LiveMode = livemode;
            Description = description;
            Metadata = metadata;

        }*/

        public Product(Guid id)
        {
            Id = id;
        }

        public Product SetCode(string code)
        {
            Check.NotNullOrWhiteSpace(code, nameof(code), ProductConsts.MaxCodeLength, ProductConsts.MinCodeLength);
            if (code.Length >= ProductConsts.MaxCodeLength)
            {
                throw new ArgumentException($"Product code can not be longer than {ProductConsts.MaxCodeLength}");
            }
            Code = code;
            return this;


        }

        public Product SetName(string name)
        {
            Check.NotNullOrWhiteSpace(name, nameof(name));
            if(name.Length > ProductConsts.MaxNameLength)
            {
                throw new ArgumentException($"Product name can not be longer than {ProductConsts.MaxNameLength}");
            }
            Name = name;
            return this;
        }
        
        public Product SetProductImage(byte[] productImage)
        {
            /*if (productImage == null)
            {
                return this;
            }*/

            ProductImage = productImage;
            return this;
        }

        public Product SetType(ProductType type)
        {
            /*if (productImage == null)
            {
                return this;
            }*/

            Type = type;
            return this;
        }
        /*public Product SetCategory(ProductCategory category)
        {
            

            Category = category;
            return this;
        }*/
        public Product SetMetaData(string metadata)
        {
            /*if (productImage == null)
            {
                return this;
            }*/

            Metadata = metadata;
            return this;
        }
        public Product SetDescription(string description)
        {
            /*if (productImage == null)
            {
                return this;
            }*/

            Description = description;
            return this;
        }
        public Product SetLiveMode(bool liveMode)
        {
            /*if (productImage == null)
            {
                return this;
            }*/

            LiveMode = liveMode;
            return this;
        }






    }
}

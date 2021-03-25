using Africell.Products;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Africell.Product.Products.Goods
{
   public  class Good : Product
    {
        public virtual bool Shippable { get; set; }
        public virtual string UnitLabel { get; set; }

        public Good()
        {

        }
       public Good(Guid id, [NotNull] string code, [NotNull] string name, ProductType type, ProductCategory category,
           string description, bool livemode, string metadata, bool shippable, string unitLabel,byte[] productImage = null)
        {


            SetCode(code);
            SetName(name);
            Type = type;
            SetCategory(category);
            Description = description;
            LiveMode = livemode;
            Metadata = metadata;
            ProductImage = productImage;
            Shippable = shippable;
            UnitLabel = unitLabel;


        }
        public Good SetCategory(ProductCategory category)
        {
            if(category != ProductCategory.Goods)
            {
                throw new ArgumentException($"Product category is not correct{category}");
            }
            Category = category;
            return this;
        }
        public Good SetShippable(bool shippable)
        {
            Shippable = shippable;
            return this;
        }
        public Good SetUnitLabel(string unitLabel)
        {
            UnitLabel = unitLabel;
            return this;
        }

    }
}

using System;
using System.Collections.Generic;
using ZShop.Shared;
using System.Linq;

namespace ZShop.Client.Services.VariantService
{
    public class VariantService : IVariantService
    {
        public List<VariantOption> EnabledVariantOptions { get; private set; }


        public void SetVariants(List<VariantOption> variants)
        {
            EnabledVariantOptions = variants;
        }

        public List<ProductVariant> GetSelectedVariants()
        {
            return EnabledVariantOptions
                .Where(o => o.Enabled == true)
                .Select(v => new ProductVariant { OriginalPrice = v.OriginalPrice, PlatformId = v.PlatformId, Price = v.Price })
                .ToList();
        }

    }
}

using System;
using System.Collections.Generic;
using ZShop.Shared;

namespace ZShop.Client.Services.VariantService
{
    public interface IVariantService
    {
        event Action OnChange;
        void SetVariants(List<VariantOption> variants);
        List<ProductVariant> GetSelectedVariants();
    }
}

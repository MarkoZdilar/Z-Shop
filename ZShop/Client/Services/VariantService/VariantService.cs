using System;
using System.Collections.Generic;
using ZShop.Shared;
using System.Linq;

namespace ZShop.Client.Services.VariantService
{
    public class VariantService : IVariantService
    {
        public List<VariantOption> EnabledVariantOptions { get; private set; }

        public event Action OnChange;

        public void SetVariants(List<VariantOption> variants)
        {
            EnabledVariantOptions = variants;
            NotifyStateChanged(); //Servis je isti i za child i za parent, dobiju isti objekt - sluzi za komunikaciju izmedju child i parent 
        }

        public List<ProductVariant> GetSelectedVariants()
        {
            return EnabledVariantOptions
                .Where(o => o.Enabled == true)
                .Select(v => new ProductVariant { OriginalPrice = v.OriginalPrice, PlatformId = v.PlatformId, Price = v.Price })
                .ToList();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}

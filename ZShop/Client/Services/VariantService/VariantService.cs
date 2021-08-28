using System;
using System.Collections.Generic;
using ZShop.Shared;
using System.Linq;

namespace ZShop.Client.Services.VariantService
{
    public class VariantService : IVariantService
    {
        public List<VariantOption> enabledVariantOptions { get; private set; }

        public event Action OnChange;

        public void SetVariants(List<VariantOption> variants)
        {
            enabledVariantOptions = variants;
            NotifyStateChanged();
        }

        public List<ProductVariant> GetSelectedVariants()
        {
            return enabledVariantOptions.Where(o => o.Enabled == true)
                .Select(v => new ProductVariant { OriginalPrice = v.OriginalPrice, PlatformId = v.PlatformId, Price = v.Price })
                .ToList();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}

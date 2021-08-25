using System;
using System.Collections.Generic;
using ZShop.Shared;

namespace ZShop.Client.Helper
{
    public class EditProductState
    {
        public List<EnabledVariantOption> enabledVariantOptions { get; private set; }

        public event Action OnChange;

        public void SetVariants(List<EnabledVariantOption> variants)
        {
            enabledVariantOptions = variants;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}

namespace ZShop.Shared
{
    public class EnabledVariantOption
    {
        public bool Enabled { get; set; }
        public int PlatformId { get; set; }
        public string PlatformName { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
    }
}

namespace IAP
{
    public class ProductMetadata
    {
        //  ISO 4217格式的幣值，ex:USD,GBD
        public string isoCurrencyCode { get; }

        // 本地化的說明
        public string localizedDescription { get; }

        // 本地化的價格 ex:0.01
        public decimal localizedPrice { get; }

        // 本地化的價格含貨幣符號 ex: $0.01
        public string localizedPriceString { get; }

        // 本地化的標題
        public string localizedTitle { get; }

        public ProductMetadata()
        {

        }

        public ProductMetadata(string priceString, string title, string description, string currencyCode, decimal localizedPrice)
        {

        }

        public ProductMetadata(ProductMetadata productMetadata)
        {

        }
    }

}

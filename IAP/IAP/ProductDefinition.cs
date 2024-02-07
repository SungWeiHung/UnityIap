using System.Collections.Generic;

namespace IAP
{
    public class ProductDefinition
    {
        // 是否啟用購買
        public bool enabled { get; }

        // 商品ID
        public string id { get; }

        // 此商品的第一筆付款單據
        public PayoutDefinition payout { get; }

        // 此商品的所有付款單據
        public IEnumerable<PayoutDefinition> payouts { get; }

        // 在特定商店中的商品ID(通常每個商店的商品ID會相同，但在某些情況下商品在不同平台可能會定義不同ID)
        public string storeSpecificId { get; }

        // 商品類型
        public ProductType type { get; }

        public ProductDefinition(string id, string storeSpecificId, ProductType type)
        {

        }

        public ProductDefinition(string id, string storeSpecificId, ProductType type, bool enabled)
        {

        }

        public ProductDefinition(string id, string storeSpecificId, ProductType type, bool enabled, PayoutDefinition payout)
        {

        }

        public ProductDefinition(string id, string storeSpecificId, ProductType type, bool enabled, IEnumerable<PayoutDefinition> payouts)
        {

        }

        public ProductDefinition(string id, ProductType type)
        {

        }
    }

}

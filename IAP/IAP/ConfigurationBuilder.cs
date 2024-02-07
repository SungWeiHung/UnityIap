using System.Collections.Generic;

namespace IAP
{
    public class ConfigurationBuilder
    {
        // 商品清單
        public HashSet<ProductDefinition> products { get; }

        // 商品清單是否使用雲端儲存的資料
        public bool useCatalogProvider { get; set; }

        /// <summary>
        /// 新增商品
        /// </summary>
        /// <param name="id">產品ID</param>
        /// <param name="type">產品類型</param>
        /// <returns>回傳的ConfigurationBuilder會包含新加入的商品清單</returns>
        public ConfigurationBuilder AddProduct(string id, ProductType type)
        {
            return new ConfigurationBuilder();
        }

        /// <summary>
        /// 新增商品
        /// </summary>
        /// <param name="id">產品ID</param>
        /// <param name="type">產品類型</param>
        /// <param name="storeIDs">在特定商店中的商品ID(通常每個商店的商品ID會相同，但在某些情況下商品在不同平台可能會定義不同ID)</param>
        /// <returns>回傳的ConfigurationBuilder會包含新加入的商品清單</returns>
        public ConfigurationBuilder AddProduct(string id, ProductType type, IDs storeIDs)
        {
            return new ConfigurationBuilder();
        }

        /// <summary>
        /// 新增商品
        /// </summary>
        /// <param name="id">產品ID</param>
        /// <param name="type">產品類型</param>
        /// <param name="storeIDs">在特定商店中的商品ID(通常每個商店的商品ID會相同，但在某些情況下商品在不同平台可能會定義不同ID)</param>
        /// <param name="payout">購買商品的定義</param>
        /// <returns>回傳的ConfigurationBuilder會包含新加入的商品清單</returns>
        public ConfigurationBuilder AddProduct(string id, ProductType type, IDs storeIDs, PayoutDefinition payout)
        {
            return new ConfigurationBuilder();
        }

        /// <summary>
        /// 新增商品
        /// </summary>
        /// <param name="id">產品ID</param>
        /// <param name="type">產品類型</param>
        /// <param name="storeIDs">在特定商店中的商品ID(通常每個商店的商品ID會相同，但在某些情況下商品在不同平台可能會定義不同ID)</param>
        /// <param name="payouts">購買商品的定義清單</param>
        /// <returns></returns>
        public ConfigurationBuilder AddProduct(string id, ProductType type, IDs storeIDs, IEnumerable<PayoutDefinition> payouts)
        {
            return new ConfigurationBuilder();
        }

        /// <summary>
        /// 新增多個商品
        /// </summary>
        /// <param name="products"></param>
        /// <returns></returns>
        public ConfigurationBuilder AddProducts(IEnumerable<ProductDefinition> products)
        {
            return new ConfigurationBuilder();
        }

        /// <summary>
        /// 依照泛型類型配置
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T Configure<T>() where T : IStoreConfiguration
        {
            return T;
        }

        /// <summary>
        /// 創建一個ConfigurationBuilder的實例
        /// </summary>
        /// <param name="first">第一個購買模組</param>
        /// <param name="rest">其餘的購買模組(不包含第一個)</param>
        /// <returns></returns>
        public static ConfigurationBuilder Instance(IPurchasingModule first, params IPurchasingModule[] rest)
        {
            return new ConfigurationBuilder();
        }
    }

}

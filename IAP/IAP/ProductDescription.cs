namespace IAP
{
    public class ProductDescription
    {
        // 商品類型
        public ProductType type;

        // 商品metadata
        public ProductMetadata metadata { get; }

        // 收據
        public string receipt { get; }

        // 商店中實際的商品ID
        public string storeSpecificId { get; }

        // 交易ID
        public string transactionId { get; set; }

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="id">商品ID</param>
        /// <param name="metadata">商品meatadata</param>
        /// <param name="receipt">收據</param>
        /// <param name="transactionId">交易ID</param>
        public ProductDescription(string id, ProductMetadata metadata, string receipt, string transactionId)
        {

        }

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="id">商品ID</param>
        /// <param name="metadata">商品meatadata</param>
        /// <param name="receipt">收據</param>
        /// <param name="transactionId">交易ID</param>
        /// <param name="type">商品類型</param>
        public ProductDescription(string id, ProductMetadata metadata, string receipt, string transactionId, ProductType type)
        {

        }

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="id">商品ID</param>
        /// <param name="metadata">商品meatadata</param>
        public ProductDescription(string id, ProductMetadata metadata)
        {

        }
    }

}

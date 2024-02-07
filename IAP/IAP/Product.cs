namespace IAP
{
    public class Product
    {
        // Apple原始交易ID
        public string appleOriginalTransactionID { get; }

        // Apple商品是否已回復
        public bool appleProductIsRestored { get; }

        // 是否為可購買
        public bool availableToPurchase { get; }

        // 定義商品在app中的內容
        public ProductDefinition definition { get; }

        // 商品資料
        public ProductMetadata metadata { get; }

        // 是否有收據
        // 非消耗品及訂閱物品必須要有收據
        // 消耗品除非是Pending，否則不會有收據
        public bool hasReceipt { get; }

        // 購買收據(json)
        public string receipt { get; }

        // 交易ID
        public string transactionID { get; }
    }

}

namespace IAP
{
    public class PurchaseFailureDescription
    {
        // 購買失敗的詳細訊息
        public string message { get; }

        // 商店中實際的商品ID
        public string productId { get; }

        // 購買失敗原因
        public PurchaseFailureReason reason { get; }

        public PurchaseFailureDescription(string productId, PurchaseFailureReason reason, string message)
        {

        }
    }

}

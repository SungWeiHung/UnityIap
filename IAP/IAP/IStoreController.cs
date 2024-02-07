namespace IAP
{
    public interface IStoreController
    {
        // 購買商品
        void InitiatePurchase(string productId);

        // 購買商品 payload ex: "Google Play"
        void InitiatePurchase(string productId, string payload);

        // 購買商品
        void InitiatePurchase(Product product);

        // 購買商品 payload ex: "Google Play"
        void InitiatePurchase(Product product, string payload);

        // 將處理中的商品完成
        void ConfirmPendingPurchase(Product product);
    }

}

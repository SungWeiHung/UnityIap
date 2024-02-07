using System.Collections.Generic;

namespace IAP
{
    public interface IStoreCallback
    {
        // 用於查詢的商品資訊
        ProductCollection products { get; }

        // 如果商店提供可靠的交易系統(例如:Apple)，則可以選擇禁用Unity IAP交易日誌
        // 預設為true
        bool useTransactionLog { get; set; }

        /// <summary>
        /// 通知Unity Purchasing所有活躍的購買
        /// </summary>
        /// <param name="purchasedProducts">所有已購買的產品</param>
        void OnAllPurchasesRetrieved(List<Product> purchasedProducts);

        /// <summary>
        /// 透過提供可用的產品清單完成設置，包含商品的metadata及相關的收據、交易ID
        /// </summary>
        /// <param name="products">產品說明清單</param>
        void OnProductsRetrieved(List<ProductDescription> products);

        /// <summary>
        /// 通知購買失敗
        /// </summary>
        /// <param name="desc">購買失敗說明</param>
        void OnPurchaseFailed(PurchaseFailureDescription desc);

        /// <summary>
        /// 通知購買成功
        /// </summary>
        /// <param name="storeSpecificId">商店實際的商品ID</param>
        /// <param name="receipt">購買收據</param>
        /// <param name="transactionIdentifier">交易ID</param>
        void OnPurchaseSucceeded(string storeSpecificId, string receipt, string transactionIdentifier);

        /// <summary>
        /// 通知無法購買
        /// </summary>
        /// <param name="reason">初始化失敗原因</param>
        /// <param name="message">有關失敗詳細訊息</param>
        void OnSetupFailed(InitializationFailureReason reason, string message);
    }

}

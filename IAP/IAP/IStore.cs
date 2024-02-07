using System.Collections.ObjectModel;

namespace IAP
{
    public interface IStore
    {
        /// <summary>
        /// 當交易被紀錄後，由Unity Purchasing呼叫，商店系統需要在這裡進行內務管理，例如關閉交易或是消耗品
        /// </summary>
        /// <param name="product">購買的商品</param>
        /// <param name="transactionId">交易ID</param>
        void FinishTransaction(ProductDefinition product, string transactionId);

        /// <summary>
        /// 使用指定的IStoreCallback初始化
        /// </summary>
        /// <param name="callback">商店的callback介面</param>
        void Initialize(IStoreCallback callback);

        /// <summary>
        /// 處理用戶購買商品請求
        /// </summary>
        /// <param name="product">購買的商品</param>
        /// <param name="developerPayload">特定商店的開發者payload(ex: Google Play)</param>
        void Purchase(ProductDefinition product, string developerPayload);

        /// <summary>
        /// 異部方式取得商品資料，包含購買收據，結束後會透過IStoreCallback回傳結果
        /// </summary>
        /// <param name="products"></param>
        void RetrieveProducts(ReadOnlyCollection<ProductDefinition> products);
    }

}

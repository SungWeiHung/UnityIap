using System;
using System.Collections.Generic;

namespace IAP
{
    public interface IStoreListener
    {
        // 初始化完成
        void OnInitialized(IStoreController controller, IExtensionProvider extensions);

        // 初始化失敗
        void OnInitializeFailed(InitializationFailureReason error, string message);

        // 購買完成
        PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs purchaseEvent);

        // 取得商品資料
        void FetchAdditionalProducts(HashSet<ProductDefinition> additionalProducts, Action successCallback, Action<InitializationFailureReason, string> failCallback);
    }

}

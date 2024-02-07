using System;
using System.Collections.Generic;

namespace IAP
{
    public class MyIAPManager : IDetailedStoreListener
    {
        private IStoreController controller;
        private IExtensionProvider extensions;

        public MyIAPManager()
        {
            var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());
            builder.AddProduct("100_gold_coins", ProductType.Consumable, new IDs
            {
                {"100_gold_coins_google", "GooglePlay"},
                {"100_gold_coins_mac", "MacAppStore"},
            });

            // 進行初始化(原先是透過UnityPurchasing去做初始化)
            //UnityPurchasing.Initialize(this, builder);
        }

        /// <summary>
        /// 初始化成功後會呼叫
        /// </summary>
        public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
        {
            this.controller = controller;
            this.extensions = extensions;
        }

        /// <summary>
        /// 遇到不可恢復的初始化錯誤時會呼叫
        ///
        /// 單純網路無法使用則不會呼叫，會持續嘗試初始化，直到可使用
        /// </summary>
        public void OnInitializeFailed(InitializationFailureReason error, string message)
        {

        }

        /// <summary>
        /// 購買成功
        ///
        /// 初始化成功後，也可能會呼叫，因為可能會有先前已購買但未標記完成的購買商品
        /// </summary>
        public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e)
        {
            return PurchaseProcessingResult.Complete;
        }


        /// <summary>
        /// 購買失敗
        /// </summary>
        public void OnPurchaseFailed(Product i, PurchaseFailureDescription p)
        {
        }

        /// <summary>
        /// 取得商品資料
        /// </summary>
        /// <param name="additionalProducts">額外要取得的商品</param>
        /// <param name="successCallback">成功的Callback</param>
        /// <param name="failCallback">失敗的Callback</param>
        public void FetchAdditionalProducts(HashSet<ProductDefinition> additionalProducts, Action successCallback, Action<InitializationFailureReason, string> failCallback)
        {

        }

        /// <summary>
        /// 進行購買
        /// </summary>
        /// <param name="id">商品ID</param>
        public void OnClickBuyButton(string id)
        {
            controller.InitiatePurchase(id);
        }
    }

}

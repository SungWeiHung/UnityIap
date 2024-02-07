namespace IAP
{
    public class StandardPurchasingModule : AbstractPurchasingModule, IPurchasingModule, IAndroidStoreSelection, IStoreConfiguration
    {
        // 安裝版本
        public string Version { get; }

        // 商店類型
        public AppStore appStore { get; }

        // 是否使用假的商店
        public bool useFakeStoreAlways { get; set; }

        // 假的商店UI
        public FakeStoreUIMode useFakeStoreUIMode { get; set; }

        /// <summary>
        /// 配置
        /// </summary>
        public override void Configure()
        {

        }

        /// <summary>
        /// 創建或搜尋一個現有的實例
        /// </summary>
        /// <returns></returns>
        public static StandardPurchasingModule Instance()
        {
            return new StandardPurchasingModule();
        }

        /// <summary>
        /// 創建或搜尋一個現有的實例，並指定商店類型
        /// </summary>
        /// <param name="androidStore">商店類型</param>
        /// <returns></returns>
        public static StandardPurchasingModule Instance(AppStore androidStore)
        {
            return new StandardPurchasingModule();
        }
    }

}

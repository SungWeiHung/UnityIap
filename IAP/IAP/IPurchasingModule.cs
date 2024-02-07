namespace IAP
{
    public interface IPurchasingModule
    {
        /// <summary>
        /// 配置購買模組
        /// </summary>
        /// <param name="binder">與購買商店綁定的物件</param>
        void Configure(IPurchasingBinder binder);
    }
}

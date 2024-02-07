namespace IAP
{
    public enum InitializationFailureReason
    {
        // 裝置禁用內購
        PurchasingUnavailable = 0,

        // 無商品可購買
        NoProductsAvailable = 1,

        // 未知的APP(通常是尚未創建APP專案在後台，或是APP識別碼設定錯誤導致無法在後台找到對應的APP專案)
        AppNotKnown = 2,
    }
}

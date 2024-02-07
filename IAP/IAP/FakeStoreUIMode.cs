namespace IAP
{
    public enum FakeStoreUIMode
    {
        // 不顯示任何對話框
        Default,

        // 在初始化、檢索商品及購買商品時，顯示選擇失敗原因代碼對話框
        DeveloperUser,

        // 購買時顯示簡單的對話框
        StandardUser,
    }
}

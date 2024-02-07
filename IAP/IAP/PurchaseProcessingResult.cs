namespace IAP
{
    public enum PurchaseProcessingResult
    {
        // 應用程式已完成購買處理，不用再通知應用程式再次交易
        Complete = 0,

        // 應用程式尚未完成購買處理，例如正在向伺服器同步購買內容，在未完成前，應用程式開始時，需要繼續通知應用程式此交易
        Pending = 1,
    }
}

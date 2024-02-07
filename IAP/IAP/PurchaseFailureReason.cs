namespace IAP
{
    public enum PurchaseFailureReason
    {
        // 重複交易
        DuplicateTransaction,

        // 交易正在處理中
        ExistingPurchasePending,

        //付款被拒絕
        PaymentDeclined,

        // 商品不可被購買
        ProductUnavailable,

        // 在安全設定中導致不可購買
        PurchasingUnavailable,

        // 收據簽章失敗
        SignatureInvalid,

        // 未知或是其餘的購買問題
        Unknown,

        // 用戶取消購買
        UserCancelled,
    }

}

namespace IAP
{
    public enum ProductType
    {
        // 消耗品(可多次購買)，商店通常不會保留購買歷史紀錄
        Consumable = 0,

        // 非消耗品(無法重複購買)，能夠無限期擁有
        NonConsumable = 1,

        // 訂閱類型
        Subscription = 2,
    }
}

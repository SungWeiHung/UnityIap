using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAP
{
    public class PayoutDefinition
    {
        public const int MaxDataLength = 1024;

        public const int MaxSubtypeLength = 64;

        // 購買物品資料用來定義UI的標誌、物品的稀有度
        public string data { get; }

        // 購買物品的數量
        public double quantity { get; }

        // 購買物品的子類型 ex: "Gold"、"Silver"、"Potion"、"Boots"
        public string subtype { get; }

        // 購買物品的類型
        public PayoutType type { get; }

        // 購買物品的類型字串
        public string typeString { get; }


        public PayoutDefinition()
        {

        }

        public PayoutDefinition(string typeString, string subtype, double quantity)
        {

        }

        public PayoutDefinition(string typeString, string subtype, double quantity, string data)
        {

        }

        public PayoutDefinition(string subtype, double quantity)
        {

        }

        public PayoutDefinition(string subtype, double quantity, string data)
        {

        }

        public PayoutDefinition(PayoutType type, string subtype, double quantity)
        {

        }

        public PayoutDefinition(PayoutType type, string subtype, double quantity, string data)
        {

        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAP
{
    public interface IDetailedStoreListener : IStoreListener
    {
        /// <summary>
        /// 購買失敗
        /// </summary>
        /// <param name="product">購買商品</param>
        /// <param name="failureDescription">購買失敗原因</param>
        void OnPurchaseFailed(Product product, PurchaseFailureDescription failureDescription);
    }
}

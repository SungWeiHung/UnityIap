using System;
using System.Collections.Generic;

namespace IAP
{
    public interface ICatalogProvider
    {
        /// <summary>
        /// 異部獲取目錄中所有的商品
        /// </summary>
        /// <param name="callback">完成時會執行的call back，並且包含商品集合</param>
        void FetchProducts(Action<HashSet<ProductDefinition>> callback);
    }
}

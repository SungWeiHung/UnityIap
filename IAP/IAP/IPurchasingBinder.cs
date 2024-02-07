using System;
using System.Collections.Generic;

namespace IAP
{
    public interface IPurchasingBinder
    {
        /// <summary>
        /// 通知Unity Purchasing有擴充的配置可使用
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="instance"></param>
        void RegisterConfiguration<T>(T instance) where T : IStoreConfiguration;

        /// <summary>
        /// 通知Unity Purchasing有商店擴充可使用
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="instance"></param>
        void RegisterExtension<T>(T instance) where T : IStoreExtension;

        /// <summary>
        /// 通知Unity Purchasing有存在的商店實例，並且指定名稱
        /// </summary>
        /// <param name="name">商店名稱</param>
        /// <param name="store">商店的實例</param>
        void RegisterStore(string name, IStore store);

        /// <summary>
        /// 通知Unity Purchasing有關目錄提供者，該目錄提供者可能會在運行的時候取代或新增商品
        /// </summary>
        /// <param name="provider">目錄提供者(包含商品清單)</param>
        void SetCatalogProvider(ICatalogProvider provider);

        /// <summary>
        /// 通知Unity Purchasing有關目錄提供者的涵式資訊，該涵式可能會在運行的時候取代或新增商品
        /// 這是SetCatalogProvider的替代方法，用於設置未實踐ICatalogProvider的提供者
        /// </summary>
        /// <param name="func">新增商品時要執行的方法</param>
        void SetCatalogProviderFunction(Action<Action<HashSet<ProductDefinition>>> func);
    }

}

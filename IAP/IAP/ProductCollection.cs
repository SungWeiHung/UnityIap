using System.Collections.Generic;
using System.Linq;

namespace IAP
{
    public class ProductCollection
    {
        // 所有商品的Array
        public Product[] all { get; }

        // 所有商品的HashSet
        public HashSet<Product> set { get; }

        // 取得與ID相符的商品
        public Product WithID(string id)
        {
            return all.FirstOrDefault(p => p.definition.id == id);
        }

        // 取得與StoreSpecificID相符的商品
        public Product WithStoreSpecificID(string id)
        {
            return all.FirstOrDefault(p => p.definition.storeSpecificId == id);
        }
    }

}

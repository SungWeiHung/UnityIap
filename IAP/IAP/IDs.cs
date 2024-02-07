using System;
using System.Collections.Generic;

namespace IAP
{
    public class IDs : IEnumerable<KeyValuePair<string, string>>, System.Collections.IEnumerable
    {
        /// <summary>
        /// 以字串的方式將產品ID新增到商店名稱清單中
        /// </summary>
        /// <param name="id">產品在特定商店中的實際ID</param>
        /// <param name="stores">商店名稱</param>
        public void Add(string id, params string[] stores)
        {

        }

        /// <summary>
        /// 以非字串(例如列舉)的方式將產品ID新增到商店名稱清單中
        /// </summary>
        /// <param name="id">產品在特定商店中的實際ID</param>
        /// <param name="stores">商店物件</param>
        public void Add(string id, params object[] stores)
        {

        }

        /// <summary>
        /// 取得產品實際ID與商店的列舉
        /// </summary>
        /// <returns></returns>
        public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
        {
            return null;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}

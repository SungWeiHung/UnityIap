using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAP
{
    // 提供對各種商店擴展的訪問的介面
    public interface IExtensionProvider
    {
        T GetExtension<T>() where T : IStoreExtension;
    }
}

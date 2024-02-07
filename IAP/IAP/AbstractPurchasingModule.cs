namespace IAP
{
    public abstract class AbstractPurchasingModule : IPurchasingModule
    {
        protected IPurchasingBinder m_Binder;

        /// <summary>
        /// 將IStoreConfiguration綁定IPurchasingBinder
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="instance"></param>
        protected void BindConfiguration<T>(T instance) where T : IStoreConfiguration
        {

        }

        /// <summary>
        /// 將IStoreExtension綁定IPurchasingBinder
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="instance"></param>
        protected void BindExtension<T>(T instance) where T : IStoreExtension
        {

        }


        /// <summary>
        /// 配置購買模組
        /// </summary>
        /// <param name="binder"></param>
        public void Configure(IPurchasingBinder binder)
        {

        }


        /// <summary>
        /// 以預設方式配置購買模組
        /// </summary>
        public abstract void Configure();

        /// <summary>
        /// 將IStore註冊至IPurchasingBinder
        /// </summary>
        /// <param name="name"></param>
        /// <param name="store"></param>
        protected void RegisterStore(string name, IStore store)
        {

        }
    }

}

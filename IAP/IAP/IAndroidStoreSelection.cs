namespace IAP
{
    public interface IAndroidStoreSelection : IStoreConfiguration
    {
        AppStore appStore { get; }
    }
}

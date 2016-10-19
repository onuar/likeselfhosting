namespace likeselfhosting
{
    public interface ICompositeConfiguratorRunnable :IServiceConfigurator
    {
        ISelfHostingInitializer Run();
    }
}
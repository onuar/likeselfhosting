namespace likeselfhosting
{
    public interface IServiceConfigurator
    {
        ICompositeConfiguratorRunnable AddComponent<TBase, TComponent>() where TBase : class
            where TComponent : class, TBase;

        ICompositeConfiguratorRunnable AddComponent<TBase, TComponent>(string name) where TBase : class
            where TComponent : class, TBase;
    }
}
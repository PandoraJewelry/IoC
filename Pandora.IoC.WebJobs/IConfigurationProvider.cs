namespace Pandora.IoC
{
    public interface IConfigurationProvider
    {
        string AppSetting(string name);
        string ConnectionString(string name);
    }
}

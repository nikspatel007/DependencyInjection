namespace DependencyInjection.Interfaces
{
    public interface IConfigProvider
    {
        /// <summary>
        /// Gets the value of a key from config files. It is upto application to provide this interface.
        /// </summary>
        /// <param name="key">Key string</param>
        /// <returns>value</returns>
        string Get(string key);
    }
}
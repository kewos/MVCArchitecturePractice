
namespace MVCArchitecturePractice.Common.Utils.Logger
{
    public interface ILoggerFactory
    {
        /// <summary>
        /// Create Logger
        /// </summary>
        /// <returns>ILogger</returns>
        ILogger Create();
    }
}

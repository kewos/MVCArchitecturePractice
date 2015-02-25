
namespace MVCArchitecturePractice.Common.Utils.Logger
{
    public class LoggerFactory : ILoggerFactory
    {
        public ILogger Create()
        {
            return new Logger();
        }
    }
}


namespace MVCArchitecturePractice.Core.Contrast
{
    /// <summary>
    /// Repository工廠
    /// </summary>
    public interface IRepositoryFactory
    {
        /// <summary>
        /// 取得 Repository
        /// </summary>
        /// <typeparam name="TRepository"></typeparam>
        /// <returns></returns>
        TRepository GetRepository<TRepository>() where TRepository : IRepository;
    }
}

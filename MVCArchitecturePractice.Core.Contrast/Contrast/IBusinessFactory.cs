
namespace MVCArchitecturePractice.Core.Contrast
{
    /// <summary>
    /// Business Logic工廠
    /// </summary>
    public interface IBusinessFactory
    {
        /// <summary>
        /// 取得Business Logic
        /// </summary>
        /// <typeparam name="TBusiness"></typeparam>
        /// <returns></returns>
        TBusiness GetBusiness<TBusiness>() where TBusiness : IBusiness;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCArchitecturePractice.Core.Contrast;

namespace MVCArchitecturePractice.Service.Contrast
{
    public interface IServiceFactory
    {
        TService GetService<TService>() where TService : IService;
    }
}

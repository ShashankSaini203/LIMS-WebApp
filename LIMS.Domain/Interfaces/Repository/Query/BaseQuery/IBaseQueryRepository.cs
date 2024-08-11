using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Domain.Interfaces.Repository.Query.BaseQuery
{
    public interface IBaseQueryRepository<T>
    {
        IEnumerable<T> GetAllAsync();

        T GetAsync(int id);
    }
}

using LIMS.Domain.Interfaces.Repository.Commands;
using LIMS.Domain.Models;
using LIMS.Infrastructure.Database.DBcontext;
using LIMS.Infrastructure.Repository.Commands.BaseCommand;

namespace LIMS.Infrastructure.Repository.Commands
{
    public class OrderCommandRepository : BaseCommandRepository<OrderDetails>, IOrderCommandRepository
    {
        public OrderCommandRepository(DataContext _dataContext) : base(_dataContext)
        {
        }
    }
}

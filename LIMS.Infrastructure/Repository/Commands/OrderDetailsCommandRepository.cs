using LIMS.Domain.Interfaces.Repository.Commands;
using LIMS.Domain.Models;
using LIMS.Infrastructure.Database.DBcontext;
using LIMS.Infrastructure.Repository.Commands.BaseCommand;

namespace LIMS.Infrastructure.Repository.Commands
{
    public class OrderDetailsCommandRepository : BaseCommandRepository<OrderDetails>, IOrderDetailsCommandRepository
    {
        public OrderDetailsCommandRepository(DataContext _dataContext) : base(_dataContext)
        {
        }
    }
}

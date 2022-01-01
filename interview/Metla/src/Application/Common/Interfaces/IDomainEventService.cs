using Metla.Domain.Common;
using System.Threading.Tasks;

namespace Metla.Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}

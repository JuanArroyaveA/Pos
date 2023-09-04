using MediatR;

namespace POS.Domain.Primitives
{
    internal record  DomainEvent(Guid Id) : INotification;

}

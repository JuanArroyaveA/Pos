using MediatR;

namespace POS.Domain.Primitives
{
    public record  DomainEvent(Guid Id) : INotification;

}

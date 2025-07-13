using MediatR;
using System;
using System.Collections.Generic;

public record CreateOrderCommand(Guid CustomerId, List<OrderItemDto> Items) : IRequest<Guid>;

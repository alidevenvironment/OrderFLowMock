using System;
using System.Collections.Generic;

public class OrderCreatedEvent
{
    public Guid OrderId { get; set; }
    public DateTime CreatedAt { get; set; }
    public List<OrderItemDto> Items { get; set; }
}

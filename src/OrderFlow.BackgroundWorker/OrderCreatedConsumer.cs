using MassTransit;
using System.Threading.Tasks;

public class OrderCreatedConsumer : IConsumer<OrderCreatedEvent>
{
    public async Task Consume(ConsumeContext<OrderCreatedEvent> context)
    {
        var projection = new OrderReadModel
        {
            OrderId = context.Message.OrderId,
            Items = context.Message.Items,
            CreatedAt = context.Message.CreatedAt
        };

        await _mongoCollection.InsertOneAsync(projection);
    }
}

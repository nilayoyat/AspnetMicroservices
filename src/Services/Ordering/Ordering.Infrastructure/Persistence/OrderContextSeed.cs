using Microsoft.Extensions.Logging;
using Ordering.Domain.Entities;

namespace Ordering.Infrastructure.Persistence
{
    public class OrderContextSeed
    {
        public static async Task SeedAsync(OrderContext orderContext, ILogger<OrderContextSeed> logger)
        {
            if (!orderContext.Orders.Any())
            {
                orderContext.Orders.AddRange(GetPreconfiguredOrders());
                await orderContext.SaveChangesAsync();
                logger.LogInformation("Seed database associated with context {DbContextName}", typeof(OrderContext).Name);
            }
        }

        private static IEnumerable<Order> GetPreconfiguredOrders()
        {
            return new List<Order>
            {
                new Order() {UserName = "swn", FirstName = "Mehmet", LastName = "Ozkaya", EmailAddress = "ezozkme@gmail.com",
                    AddressLine = "Bahcelievler", Country = "Turkey", TotalPrice = 350, CVV="some cvv", CardName="CardName",
                    PaymentMethod =2, CardNumber="40223535262635352626", Expiration= "02/2024", LastModifiedBy="nil", LastModifiedDate= DateTime.Now,
                CreatedBy="nil", CreatedDate= DateTime.Now, State = "S", ZipCode="6545"}
            };
        }
    }
}
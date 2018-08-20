using System.Data.Entity.Infrastructure;
using Microsoft.EntityFrameworkCore;

public class ShippingContextFactory : IDbContextFactory<ShippingContext>
{
    public ShippingContextFactory Create()
    {
        return new EF.ShippingContext("Server=(localdb)\\mssqllocaldb;Database=EF6MVCCore;Trusted_Connection=True;MultipleActiveResultSets=true");
    }

    ShippingContext IDbContextFactory<ShippingContext>.Create()
    {
        return new EF.ShippingContext("Server=(localdb)\\mssqllocaldb;Database=EF6MVCCore;Trusted_Connection=True;MultipleActiveResultSets=true");
    }
}
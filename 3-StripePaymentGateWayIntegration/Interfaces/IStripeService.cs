using _3_StripePaymentGateWayIntegration.Resources;

namespace _3_StripePaymentGateWayIntegration.Interfaces
{
    public interface IStripeService
    {
        Task<CustomerResource> CreateCustomer(CreateCustomerResource resource, CancellationToken cancellationToken);
        Task<ChargeResource> CreateCharge(CreateChargeResource resource, CancellationToken cancellationToken);
    }
}

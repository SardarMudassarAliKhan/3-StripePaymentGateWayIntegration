namespace _3_StripePaymentGateWayIntegration.Resources
{
    public record CreateCustomerResource(
    string Email,
    string Name,
    CreateCardResource Card);
}

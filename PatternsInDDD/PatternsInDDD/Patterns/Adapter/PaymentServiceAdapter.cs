namespace PatternsInDDD.Patterns.Adapter;

/// <summary>
/// The Adapter Pattern is a Structural design pattern that allows objects
/// with incompatible interfaces to collaborate. It's often used when you want
/// to integrate a new component into an existing system without changing the system's
/// existing code.
///
/// While this pattern is primarily a pattern focused on system integration and interface
/// compability, can be quite relevant in the context of DDD:
/// - Separation of Domain and Infrastructure concerns:
///     DDD emphasizes a clear separation between the domain model (business logic / invariants)
///     and infrastructure concerns (e.g databases, third-party integrations).
///     The adapter pattern plays an important role in achieving this separation by allowing the
///     domain model to retain agnostic to specific external service implementations
///     or infrastructure details.
///     For instance, if your domain logic requires interacting with external services like payment
///     gateways, or email services, you can use adapters to integrate these services without
///     polluting the domain layer with infrastructure-centric code.
/// - Isolation of External Systems and Changes:
///     In DDD, it's crucial to protect the domain model from changes in external systems. The adapter
///     pattern helps isolate the  domain from these changes. When an external system changes its API or
///     behavior, you only need to modify the adapter, leaving hte domain model unaffected.
///     This isolation is particularly important when dealing with legacy systems or third-party APIs, where
///     changes can happen often and they can be unpredictable.
/// - Facilitating Bounded Context Integration:
///     In a system with multiple bounded contexts, different contexts might need to communicate with each
///     other while maintaining their autonomy. The adapter pattern can be used to translate between different
///     models of the bounded context, ensuring that each context remains cohesive and loosely coupled with others.
///     This is especially useful in large systems where different teams might work on different  contexts using
///     different technologies or data models.
/// - Supporting the Anti-Corruption Layer (ACL):
///     In DDD, ACL is often used to prevent concepts with different semantics from a legacy system or external system
///     from leaking into your domain model. Adapters can be part of this layer, translating between the external
///     models and the internal domain model, thereby preventing corruption of the domain model.
///     This approach ensure that the integrity of the domain model is maintained, and the business logic remains pure
///     and unaffected by external influences.
/// - Enabling Testability:
///     By using adapters to handle external dependencies, it becomes easier to test the domain model in isolation.
///     For instance, you can use Mock implementations of the adapters in unit tests, focusing solely on the domain
///     logic without worrying about the actual implementation of external services.
/// </summary>
public class PaymentServiceAdapter : IExistingPaymentGateway
{
    private readonly INewPaymentGateway _newPaymentGateway;

    public PaymentServiceAdapter(INewPaymentGateway newPaymentGateway)
    {
        _newPaymentGateway = newPaymentGateway;
    }

    public bool ProcessPayment(string creditCardNumber, decimal amount)
    {
        // Adapting the new method to the existing interface
        string result = _newPaymentGateway.MakePayment(creditCardNumber, "12/24", amount);
        
        // Assume payment was successful.
        return true;
    }
}
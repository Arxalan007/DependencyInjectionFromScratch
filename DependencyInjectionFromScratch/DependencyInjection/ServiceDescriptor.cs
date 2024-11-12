namespace DependencyInjectionFromScratch.DependencyInjection;

public class ServiceDescriptor
{
    public ServiceDescriptor(object implementation, ServiceLifetime serviceLifetime)
    {
        ServiceType = implementation.GetType();
        Implementation = implementation;
        ServiceLifetime = serviceLifetime;
    }
    
    public ServiceDescriptor(Type serviceType, ServiceLifetime serviceLifetime)
    {
        ServiceType = serviceType;
        ServiceLifetime = serviceLifetime;
    }

    public ServiceDescriptor(Type serviceType, Type implementationType, ServiceLifetime serviceLifetime)
    {
        ServiceType = serviceType;
        ImplementationType = implementationType;
        ServiceLifetime = serviceLifetime;
        
    }

    public Type ServiceType { get; }
    
    public Type ImplementationType { get; }

    public object Implementation { get; internal set; }
    
    public ServiceLifetime ServiceLifetime { get; }
}
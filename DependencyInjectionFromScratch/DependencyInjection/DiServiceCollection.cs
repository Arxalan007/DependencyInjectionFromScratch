﻿namespace DependencyInjectionFromScratch.DependencyInjection;

public class DiServiceCollection
{
    private List<ServiceDescriptor> _serviceDescriptors = new List<ServiceDescriptor>();
    
    public void RegisterSingleton<TService, TImplementation>() where TImplementation : TService
    {
        _serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), typeof(TImplementation), ServiceLifetime.Singleton));
    }
    
    public void RegisterSingleton<TService>()
    {
        _serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), ServiceLifetime.Singleton));
    }

    public void RegisterTransient<TService, TImplementation>() where TImplementation : TService
    {
        _serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), typeof(TImplementation), ServiceLifetime.Transient));
    }
    
    public void RegisterTransient<TService>()
    {
        _serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), ServiceLifetime.Transient));
    }
    
    public DiContainer GenerateContainer()
    {
        return new DiContainer(_serviceDescriptors);
    }
}
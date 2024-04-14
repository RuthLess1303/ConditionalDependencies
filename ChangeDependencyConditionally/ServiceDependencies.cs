using ChangeDependencyConditionally.ServiceDependencies.Enums;
using ChangeDependencyConditionally.ServiceDependencies.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ChangeDependencyConditionally.ServiceDependencies;

public class ServiceDependencies(IServiceCollection collection)
{
    public void ServiceCollectionBuild()
    {
        
    }
}
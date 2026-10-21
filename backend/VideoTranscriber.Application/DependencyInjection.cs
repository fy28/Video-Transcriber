using Microsoft.Extensions.DependencyInjection;

namespace VideoTranscriber.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // Application services will be registered here as use cases are added.
        return services;
    }
}

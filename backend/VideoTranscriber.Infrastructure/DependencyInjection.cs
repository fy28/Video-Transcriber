using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VideoTranscriber.Infrastructure.Configuration;

namespace VideoTranscriber.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.Configure<HuggingFaceOptions>(
            configuration.GetSection(HuggingFaceOptions.SectionName));

        // External integrations will be registered here when they are implemented.
        return services;
    }
}

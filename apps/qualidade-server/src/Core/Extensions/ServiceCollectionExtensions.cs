using Qualidade.APIs;

namespace Qualidade;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Add services to the container.
    /// </summary>
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<ICausaRaizsService, CausaRaizsService>();
        services.AddScoped<IEstatisticasService, EstatisticasService>();
        services.AddScoped<IReclamacoesService, ReclamacoesService>();
        services.AddScoped<IRncsService, RncsService>();
    }
}

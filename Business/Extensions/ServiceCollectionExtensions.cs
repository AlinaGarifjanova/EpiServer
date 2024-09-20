using Microsoft.AspNetCore.Mvc;

namespace EpiServerProject.Business.Extensions;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddNack(this IServiceCollection services)
	{
		services.Configure<MvcOptions>(options => options.Filters.Add<PageContextActionFilter>());

		return services;
	}
}

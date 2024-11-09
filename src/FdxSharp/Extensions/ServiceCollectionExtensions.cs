using FdxSharp.Auth;
using FdxSharp.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace FdxSharp.Extensions
{
	/// <summary>
	/// Extension methods for the <see cref="IServiceCollection"/> interface.
	/// </summary>
	public static class ServiceCollectionExtensions
	{
		/// <summary>
		/// Adds the FdxSharp services to the <see cref="IServiceCollection"/>.
		/// </summary>
		/// <param name="services"></param>
		/// <param name="configuration"></param>
		/// <param name="sectionName"></param>
		/// <returns></returns>
		public static IServiceCollection AddFdxSharp(this IServiceCollection services, IConfiguration configuration, string sectionName = "FdxSharp")
		{
			services.AddHttpClient();
			services.AddLogging();

			services.Configure<FdxClientOptions>(configuration.GetSection(sectionName));

			services.TryAddScoped<IOAuthClient, OAuthClient>();
			services.TryAddScoped<IFdxClient, FdxClient>();

			return services;
		}

		/// <summary>
		/// Adds the FdxSharp services to the <see cref="IServiceCollection"/>.
		/// </summary>
		/// <param name="services"></param>
		/// <param name="configureOptions"></param>
		/// <returns></returns>
		public static IServiceCollection AddFdxSharp(this IServiceCollection services, Action<FdxClientOptions> configureOptions)
		{
			services.AddHttpClient();
			services.AddLogging();

			services.Configure(configureOptions);

			services.TryAddScoped<IOAuthClient, OAuthClient>();
			services.TryAddScoped<IFdxClient, FdxClient>();

			return services;
		}
	}
}

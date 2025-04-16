//  ConfigureSerivcesExtension
//  ----------------------------------------------
//  Extensions for configuration of ASP.NET Core.
//  ----------------------------------------------
//  Created: 2018-08-18
//  Created by: Mikael Ekroth (mikael.kl.ekroth@gmail.com)
//
//  Copyright 2018
using Microsoft.Extensions.DependencyInjection;
using MultiSearch.Library.Managers;
using MultiSearch.Library.Managers.Interfaces;
using MultiSearch.Library.Services;
using MultiSearch.Library.Services.Interfaces;

namespace MultiSearch.Web.Extensions
{
    public static class ConfigureSerivcesExtensions
    {
        /// <summary>
        /// Registry the dependancies for the application.
        /// Setting up which managers the application should use and services.
        /// </summary>
        /// <param name="services">Flued chained service collections object</param>
        /// <returns>Returns the modified service collection.</returns>
        public static IServiceCollection RegistryDependencies(this IServiceCollection services)
        {
            services.AddScoped<ISearchService, SearchService>();
            services.AddSingleton<ISearchManager, MultiSearchManager>();

            return services;
        }
    }
}

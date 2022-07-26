﻿using Microsoft.Extensions.DependencyInjection;
using System;
using KarateSocial.Application.Interfaces;
using KarateSocial.Application.Services;
using KarateSocial.Data.Repositories;
using KarateSocial.Domain.Interfaces;

namespace KarateSocial.IoC
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region Services

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IPersonService, PersonService>();
            
            #endregion

            #region Repositories
            
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IPersonRepository, PersonRepository>();
            
            #endregion
        }
    }
}

// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Extensions.DependencyInjection;
using System;

namespace Microsoft.Owin.Hosting.Builder
{
    /// <summary>
    /// Used to instantiate the application entry point. e.g. the Startup class.
    /// </summary>
    public class AppActivator : IAppActivator
    {
        private readonly IServiceProvider _services;

        /// <summary>
        /// Creates a new AppActivator.
        /// </summary>
        /// <param name="services"></param>
        public AppActivator(IServiceProvider services)
        {
            _services = services;
        }

        /// <summary>
        /// Instantiate an instance of the given type, injecting any available services.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public virtual object Activate(Type type)
        {
            return ActivatorUtilities.GetServiceOrCreateInstance(_services, type);
        }
    }
}
﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Data.SqlCommands
{
    public static class Register
    {
        public static IServiceCollection AddSqlCommandService(this IServiceCollection services)
        {
            return services;
        }
    }
}

﻿using System.Reflection;
using Application.Interfaces;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddSingleton<IEditorService, EditorService>();
        services.AddSingleton<INewsService, NewsService>();
        services.AddSingleton<IMarkService, MarkService>();
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
    }
}
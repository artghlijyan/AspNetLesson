﻿using AspNetLesson.Middleware;
using Microsoft.AspNetCore.Builder;

namespace MiddleWareExtensions
{
    public static class TokenExtensions
    {
        public static IApplicationBuilder UseToken(this IApplicationBuilder builder, string token)
        {
            return builder.UseMiddleware<TokenMiddleware>(token);
        }
    }
}

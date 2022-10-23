using asp02.middlenware;

namespace ASP02
{
    public static class UseFirstmiddlewareMethod
    {
        public static void UseFirstmiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<Firstmiddleware>();
        }

        public static void UseSecondmiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<SecondMiddleware>();
        }
    }
}
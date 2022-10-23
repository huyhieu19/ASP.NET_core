namespace asp02.middlenware
{
    public class SecondMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            if (context.Request.Path != "/xxx.html")
            {
                var dataFromFirstMiddleware = context.Items["DataFirstMiddleware"];
                await context.Response.WriteAsync("Ban duoc truy cap\n");
                if (dataFromFirstMiddleware != null)
                {
                    await context.Response.WriteAsync((string)dataFromFirstMiddleware);
                }
                await next(context);
            }
            else
            {
                await context.Response.WriteAsync("\nBan khong duoc truy cap");
                var dataFromFirstMiddleware = context.Items["DataFirstMiddleware"];
                if (dataFromFirstMiddleware != null)
                {
                    await context.Response.WriteAsync((string)dataFromFirstMiddleware);
                }
            }
        }
    }
}
namespace ASP02
{
    public class Firstmiddleware
    {
        private readonly RequestDelegate _next;
        public Firstmiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            context.Items.Add("DataFirstMiddleware", $"URL: + {context.Request.Path.ToString()}");
            await _next(context);
        }
    }
}
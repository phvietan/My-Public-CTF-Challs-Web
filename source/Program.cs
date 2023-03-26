var builder = WebApplication.CreateBuilder();
builder.Services.AddRazorPages();
builder.Services.AddResponseCaching();

var app = builder.Build();

app.UseExceptionHandler("/Error");
app.UseResponseCaching();
app.UseStaticFiles(new StaticFileOptions()
{
    HttpsCompression = Microsoft.AspNetCore.Http.Features.HttpsCompressionMode.Compress,
    OnPrepareResponse = (context) =>
    {
        var headers = context.Context.Response.GetTypedHeaders();
        headers.CacheControl = new Microsoft.Net.Http.Headers.CacheControlHeaderValue
        {
            Public = true,
            MaxAge = TimeSpan.FromMinutes(60),
        };
    }
});
app.MapRazorPages();
app.Use(async (context, next) =>
    {
        await next();
        if (context.Response.StatusCode == 404)
        {
            context.Response.Redirect("/", true);
        }
    });
app.Run();

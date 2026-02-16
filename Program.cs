using MicroservicesSample.Client;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// .NET 9 built-in OpenAPI
builder.Services.AddOpenApi();

var app = builder.Build();

builder.Services.AddHttpClient<PaymentClient>();


if (app.Environment.IsDevelopment())
{
    // Generates /openapi/v1.json
    app.MapOpenApi();

    // Swagger UI at /swagger (uses the OpenAPI json above)
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "My API v1");
        options.RoutePrefix = "swagger";
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();

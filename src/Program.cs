var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();

var app = builder.Build();

app.MapOpenApi();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/openapi/v1.json", "BugStore v1");
});

app.MapGet("/", () => "Hello World!");

app.MapGet("/v1/customers", () => "Hello World!");
app.MapGet("/v1/customers/{id}", () => "Hello World!");
app.MapPost("/v1/customers", () => "Hello World!");
app.MapPut("/v1/customers/{id}", () => "Hello World!");
app.MapDelete("/v1/customers/{id}", () => "Hello World!");

app.MapGet("/v1/products", () => "Hello World!");
app.MapGet("/v1/products/{id}", () => "Hello World!");
app.MapPost("/v1/products", () => "Hello World!");
app.MapPut("/v1/products/{id}", () => "Hello World!");
app.MapDelete("/v1/products/{id}", () => "Hello World!");

app.MapGet("/v1/orders/{id}", () => "Hello World!");
app.MapPost("/v1/orders", () => "Hello World!");

app.Run();

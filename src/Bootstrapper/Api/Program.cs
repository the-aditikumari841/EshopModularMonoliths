using Basket;
using Catalog;
using Ordering;

var builder = WebApplication.CreateBuilder(args);

//Add services to the container
builder.Services.AddCatalogModule(builder.Configuration).AddBasketModule(builder.Configuration).AddOrderingModule(builder.Configuration);

var app = builder.Build();

//  Configure the HTTP request pipeline


////Use static files
//app.UseStaticFiles();

//// Use routing
//app.UseRouting();

//// Use authentication
//app.UseAuthentication();

//// Use authorization
//app.UseAuthorization();

//// Define endpoints
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllers();
//});

app.Run();

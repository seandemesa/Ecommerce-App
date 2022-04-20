global using EcommerceApp.Shared;
global using System.Net.Http.Json;
global using EcommerceApp.Client.Services;
global using EcommerceApp.Client.Services.CategoryService;
global using EcommerceApp.Client.Services.CartService;
global using EcommerceApp.Client.Services.AuthService;
global using EcommerceApp.Client.Services.OrderService;
global using EcommerceApp.Client.Services.AddressService;
global using EcommerceApp.Client.Services.ProductTypeService;
global using Microsoft.AspNetCore.Components.Authorization;
using EcommerceApp.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored.LocalStorage;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<IProductTypeService, ProductTypeService>();
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();

await builder.Build().RunAsync();

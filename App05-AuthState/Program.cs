using App05_AuthState.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// REGISTER THE AUTHENTICATION SERVICE AS A SINGLETON
builder.Services.AddSingleton<AuthenticationStateService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App05_AuthState.Components.App>()
    .AddInteractiveServerRenderMode();

app.Run();
var builder = WebApplication.CreateBuilder(args);

// Adiciona os serviços necessários para suportar o padrão MVC (Controllers e Views)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configuração do pipeline de requisições HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // Opcional: Ativar HSTS em produção
    app.UseHsts();
}

app.UseHttpsRedirection();

// Permite servir ficheiros estáticos (imagens, CSS, JavaScript) armazenados na pasta wwwroot
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Define a rota predefinida para o padrão MVC
// Exemplo: /Home/Index ou simplesmente a raiz do site apontando para o HomeController e a Action Index
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

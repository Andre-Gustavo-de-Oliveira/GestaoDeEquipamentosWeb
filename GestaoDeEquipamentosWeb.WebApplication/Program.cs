using GestaoDeEquipamentosWeb.WebApp.Compartilhado.Apresesntacao;
using GestaoDeEquipamentosWeb.WebApp.Compartilhado.Infraestrutura;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AdicionarCamadaDeInfraestrutura();

builder.Services.AdicionarCamadaDeApresentacao();

var app = builder.Build();

app.UseRouting();
app.MapDefaultControllerRoute();

app.UseStaticFiles();

app.Run();
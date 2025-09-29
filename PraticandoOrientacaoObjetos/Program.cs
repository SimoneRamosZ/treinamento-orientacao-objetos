using PraticandoOrientacaoObjetos.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var clienteBase = new ClienteBase();
var descontoBase = clienteBase.CalcularDesconto();

var clienteEspecial = new ClienteEspecial();
var descontoEspecial = clienteEspecial.CalcularDesconto();

Console.WriteLine(descontoBase.ToString());
Console.WriteLine(descontoEspecial.ToString());

app.Run();

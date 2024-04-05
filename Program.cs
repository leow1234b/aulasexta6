using API.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Produto Produto = new Produto();

List<Produto> produtos = new List<Produto>();
produtos.Add(new Produto("Celular", "IOS",8));
produtos.Add(new Produto("Celular", "Android",9));
produtos.Add(new Produto("Televisão", "LG",7));
produtos.Add(new Produto("Notebook", "Avell",10));

//EndPoints - Funcionalidades
//GET: http://localhost:5225/
app.MapGet("/", () => "Minha primeira API em C# com watch");

//GET: http://localhost:5225/api/produto/listar
app.MapGet("/api/produto/listar", () => 
    produtos);

//POST: http://localhost:5225/api/produto/cadastrar
app.MapPost("/api/produto/cadastrar", () => 
    "Cadastro de produtos");

app.Run();


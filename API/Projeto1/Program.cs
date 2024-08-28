//Testar as APIs 
//Rest client(extensao do vs), postman, insomnia 
// MINIMAL APIs
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


//EndPoints - Funcionalidades
//Configurar a URL e o método/verbo
app.MapGet("/", () => "Hello World!");

app.Run();

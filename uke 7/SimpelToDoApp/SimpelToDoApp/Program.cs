using SimpelToDoApp.Model;
using System.Numerics;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var inmemoryDb = new List<ToDoItem> 
{
    new ToDoItem("Spise kvikklunsj"),
    new ToDoItem("Skifte dekk") {Done = new DateTime(2022,10,04) }
};

app.MapGet("/todo", () =>
{
    return inmemoryDb;
});
app.MapPost("/todo",(ToDoItem todoitem) =>
{
    inmemoryDb.Add(todoitem);
});
app.MapPut("/todo/{id}", (Guid id) =>
{
    var todoitem = inmemoryDb.SingleOrDefault(ti => ti.Id == id);
    todoitem.Done = DateTime.Today;
});
app.MapDelete("/todo/{id}", (Guid id) =>
{
    inmemoryDb.RemoveAll(ti => ti.Id == id);
});
app.UseStaticFiles();
app.Run();

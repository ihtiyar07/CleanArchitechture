/* using SolutionToDoApp.Infrastructure.Mapping;
 */
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
// Swagger hizmetini ekleyin
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ITaskRepository, TaskRepository>();
builder.Services.AddScoped<ITaskService, TaskService>();
/* builder.Services.AddAutoMapper(typeof(MappingProfile));
 */



builder.Services.AddScoped<IGetTaskById, GetToDoItemById>();
builder.Services.AddScoped<IGetAllTask, GetlAllToDoItem>();
builder.Services.AddScoped<IUpdateTask, UpdateToDoItemCommands>();
builder.Services.AddScoped<IAddTask, CreateToDoItemCommands>();
builder.Services.AddScoped<IDeleteTask, DeleteToDoItemCommands>();






var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        c.RoutePrefix = "api"; // Swagger UI root yolunda çalışacak
    });
}


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Task}/{action=Index}/{id?}");

app.Run();

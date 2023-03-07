using Helper.Core;
using TeacherService.Setup;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.SetupApplicationServices();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//global exception
app.UseMiddleware<GlobalExceptionHandler>();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

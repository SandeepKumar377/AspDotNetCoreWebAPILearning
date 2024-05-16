using AspDotNetCoreWebAPILearning.Utility;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var schoolInfo = new SchoolInfo();
builder.Configuration.GetSection("SchoolInfo").Bind(schoolInfo);
builder.Services.AddSingleton(schoolInfo);

builder.Services.Configure<CompanyInfo>(builder.Configuration.GetSection("CompanyInfo"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

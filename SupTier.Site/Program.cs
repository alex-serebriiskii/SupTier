using Microsoft.AspNetCore.SpaServices.AngularCli;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(
    option => 
    {
        option.AddPolicy(name: "testPolicy",
            policy => 
            {
                policy.WithOrigins("http://localhost:4200");
            });
    }
);
builder.Services.AddSpaStaticFiles(configuration => 
{
    configuration.RootPath = "frontend/dist/frontend/browser";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseStaticFiles();
if(!app.Environment.IsDevelopment())
{
    app.UseSpaStaticFiles();
}

app.UseSpa(spa =>
{
    spa.Options.SourcePath = "frontend";
    if(app.Environment.IsDevelopment())
    {
        spa.UseAngularCliServer(npmScript: "start");
    }
    else{

    }
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

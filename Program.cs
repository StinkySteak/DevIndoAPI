var builder = WebApplication.CreateBuilder(args);

var MyAllowSpecificOrigins = "Access-Control-Allow-Origin";
var MyAllowSpecificOriginsx = "Access-Control-Allow-Headers";

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:3000",
                                              "http://localhost:3000");
                      });
    options.AddPolicy(name: MyAllowSpecificOriginsx,
                     policy =>
                     {
                         policy.WithOrigins("http://localhost:3000",
                                             "http://localhost:3000");
                     });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors(options => options.WithOrigins("http://localhost:3000").AllowAnyMethod().AllowAnyHeader());
app.MapControllers();
app.Run();

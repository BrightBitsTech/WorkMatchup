using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using webapi.Authorization;
using webapi.Helpers;
using webapi.Interfaces;
using webapi.Services;

var builder = WebApplication.CreateBuilder(args);
{
    var services = builder.Services;
    var env = builder.Environment;

    services.AddDbContext<DataContext>();
    services.AddCors();
    services.AddControllers().AddJsonOptions(x =>
    {
        x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });
    services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
    services.AddSwaggerGen();
    services.AddAutoMapper(typeof(Program));

    services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));
    services.AddHttpClient();
    services.AddScoped<IJwtUtils, JwtUtils>();
    services.AddScoped<IAccountService, AccountService>();
    services.AddScoped<ICVParserService, CVParserService>();
    services.AddScoped<IEmailService, EmailService>();
    services.AddScoped<IJobOfferService, JobOfferService>();
    services.AddScoped<INetworkService, NetworkService>();
    services.AddScoped<IProfessionalEventService, ProfessionalEventService>();
    services.AddScoped<ISkillsService, SkillsService>();
    services.AddScoped<IUserRecommendationService, UserRecommendationService>();

}
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dataContext = scope.ServiceProvider.GetRequiredService<DataContext>();
    dataContext.Database.Migrate();
}


app.UseSwagger();
app.UseSwaggerUI(x => x.SwaggerEndpoint("/swagger/v1/swagger.json", ".NET Sign-up and Verification API"));

app.UseCors(x => x
    .SetIsOriginAllowed(origin => true)
    .AllowAnyMethod()
    .AllowAnyHeader()
    .AllowCredentials());

app.UseHttpsRedirection();
app.UseAuthentication();

app.UseAuthorization();

app.UseMiddleware<ErrorHandlerMiddleware>();

app.UseMiddleware<JwtMiddleware>();
app.MapControllers();

app.Run();

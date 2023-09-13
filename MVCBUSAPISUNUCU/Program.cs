using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MVCBUSAPI.Data;
using MVCBUSAPI.Entites;
using MVCBUSAPI.Repositories.Abstract;
using MVCBUSAPI.Repositories.Concreate;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
 builder.Services.AddControllers().AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore); //CYCLE HATASI VERÝRSE BURAYA BUNU EKLERÝZ.

            builder.Services.AddDbContext<OtobüsDBContext>(
                o => o.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("OtoüsDBString"))

                );

            builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<OtobüsDBContext>().AddDefaultTokenProviders();

            builder.Services.AddScoped<ISeferRepo, SeferRepo>()
                            .AddScoped<IFirmaRepo, FirmaRepo>()
                            .AddScoped<IOtobüsRepo, OtobüsRepo>()
                            .AddScoped<IAppUserRepo, AppUserRepo>()
                            .AddScoped<IAppRoleRepo, AppRoleRepo>();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

//builder.AddBuilder();

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

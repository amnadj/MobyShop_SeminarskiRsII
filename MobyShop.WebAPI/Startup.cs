using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using MobyShop.Model;
using MobyShop.Model.Requests;
using MobyShop.WebAPI.Filters;
using MobyShop.WebAPI.Security;
using MobyShop.WebAPI.Services;

namespace MobyShop.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        [Obsolete]
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddMvc(x => x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<MyContext>(x => x.UseSqlServer(Configuration.GetConnectionString("localDatabase")));
            //services.AddDbContext<MyContext>(x => x.UseSqlServer(Configuration.GetConnectionString("DockerSQL")));

            services.AddScoped<IUlogeService, UlogeService>();
            services.AddScoped<IKorisniciService, KorisniciService>();
            services.AddScoped<IService<Models.Klijenti, object>, BaseService<Models.Klijenti, object, Database.Klijenti>>();

            services.AddScoped<IKlijentiService, KlijentiService>();

            services.AddScoped<IArtikliService, ArtikliService>();

            services.AddScoped<IService<Models.Modeli, object>, BaseService<Models.Modeli, object, Database.Modeli>>();
            services.AddScoped<ICRUDService<Models.Modeli, object, ModeliInsertRequest, object>, ModeliService>();

            services.AddScoped<IService<Models.Proizvodjaci, object>, BaseService<Models.Proizvodjaci, object, Database.Proizvodjaci>>();
            services.AddScoped<ICRUDService<Models.Proizvodjaci, object, ProizvodjaciInsertRequest, object>, ProizvodjaciService>();

            services.AddScoped<IService<Models.Karakteristike, object>, BaseService<Models.Karakteristike, object, Database.Karakteristike>>();
            services.AddScoped<ICRUDService<Models.Karakteristike, object, KarakteristikeInsertRequest, object>, KarakteristikeService>();

            services.AddScoped<IDobavljaciService, DobavljaciService>();
            services.AddScoped<IService<Models.Dobavljaci, object>, BaseService<Models.Dobavljaci, object, Database.Dobavljaci>>();

            services.AddScoped<ISkladistaService, SkladistaService>();

            services.AddScoped<IStavkeNabavkeService, StavkeNabavkeService>();
            services.AddScoped<INabavkeService, NabavkeService>();

            services.AddScoped<IService<Models.PoslanaNarudzba, object>, BaseService<Models.PoslanaNarudzba, object, Database.PoslanaNarudzba>>();
            services.AddScoped<ICRUDService<Models.PoslanaNarudzba, object, PoslanaNarudzbaInsertRequest, PoslanaNarudzbaUpdateRequest>, IPoslanaNarudzba>();

            services.AddScoped<INarudzbeService, NarudzbeService>();
            services.AddScoped<IStavkeNarudzbeService, StavkeNarudzbeService>();

            services.AddScoped<IService<Models.Ocjene, object>, BaseService<Models.Ocjene, object,Database.Ocjene>>();
            services.AddScoped<ICRUDService<Models.Ocjene, object, OcjeneInsertRequest, object>, OcjeneService>();

            services.AddScoped<IRecommender, RecommenderService>();

            services.AddScoped<ICRUDService<Models.NarudzbePracenjeInfo, NarudzbePracenjeInfoSearchRequest, NarudzbePracenjeInfoInsertRequest, object>, NarudzbePracenjeInfoService>();

            services.AddAutoMapper(typeof(Startup));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MobileShop API", Version = "v1" });

                c.AddSecurityDefinition("basicAuth", new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "basicAuth" }
                        },
                        new string[]{}
                    }
                });
            });

            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });


        }
    }
}

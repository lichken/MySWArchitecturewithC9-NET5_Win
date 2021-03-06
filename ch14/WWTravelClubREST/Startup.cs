using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.OpenApi.Models;

namespace WWTravelClubREST
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddControllers();
            services.AddDbContext<WWTravelClubDB.MainDBContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),
                 b => b.MigrationsAssembly("WWTravelClubDB")));

            //services.AddDbContext<WWTravelClubDB.MainDBContext>(options =>
            //    options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=wwtravelclub;Trusted_Connection=True",
            //     b => b.MigrationsAssembly("WWTravelClubDB")));

            //services.AddDbContext<WWTravelClubDB.MainDBContext>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("WWWTravelClub", new OpenApiInfo
                {
                    Version = "WWWTravelClub 1.0.0",
                    Title = "WWWTravelClub",
                    Description = "WWWTravelClub Api",
                    TermsOfService = null

                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHsts();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
           {
               c.SwaggerEndpoint(
                    "/swagger/WWWTravelClub/swagger.json",
                    "WWWTravelClub Api"
               );
           });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });



            
        }
    }
}

using Core.His.CustomHandler;
using DataAccess.Entities.His.Entities;
using DataAccess.Entities.His.Entities;
using DataAccess.Entities.His.HisEntities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Security.Claims;

namespace PortalHisApi
{
    public class Startup
    {
        readonly string MyAllowSpecificOrigins = "CORSPolicy";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            var connectionString = Configuration.GetConnectionString("PortalHis");
            ServiceRegistry.RegisterServices(services, connectionString, Configuration);

            //services.AddCors(o => o.AddPolicy(MyAllowSpecificOrigins, builder =>
            //{
            //    builder.AllowAnyOrigin()
            //           .AllowAnyMethod()
            //           .AllowAnyHeader()
            //           .WithHeaders("x-custom-header");
            //    ;
                       
            //}));

            services.AddAuthorization();

 
            services.AddControllersWithViews().AddNewtonsoftJson(options =>
   options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
); ;

            services.AddDbContext<PortalHisContext>(options => options.UseSqlServer(connectionString, optionBuilder => optionBuilder.MigrationsAssembly("DataAccess.Entities.His")));

            services.AddAuthentication();
                
            //    .AddGoogle(opt =>
            //{
            //    opt.ClientId = "639675427675-b85b6rskdhug3keveidl7d07bg1nhr6p.apps.googleusercontent.com";
            //    opt.ClientSecret = "";
            //});

 

            services.AddIdentity<AppUser, AppRole>()
               
                .AddEntityFrameworkStores<PortalHisContext>()
                .AddDefaultTokenProviders();


            services.AddMvc();
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "app";
            });


            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            if (!env.IsDevelopment())
            {
                app.UseSpaStaticFiles();
            }
            app.UseRouting();
            app.UseCors(MyAllowSpecificOrigins);
            app.UseAuthentication();




            // are you allowed?  
            app.UseAuthorization();
             
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Api}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "app";

                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }

            });


        }
    }
}

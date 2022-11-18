
using DinkToPdf;
using DinkToPdf.Contracts;
using Layer.Core.Interfaces.BLL;
using Layer.Core.Interfaces.Repository;
using Layer.Core.Interfaces.Service;
using Layer.Core.Interfaces.UnitOfWork;
using Layer.Repository.DbAccess;
using Layer.Repository.Repositories;
using Layer.Repository.UnitOfWork;
using Layer.Service.Business;
using Layer.Service.Mapping;
using Layer.Service.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Logo
{
    public class Startup
    {
      
        public Startup(IConfiguration configuration, Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment)
        {
            Configuration = configuration;
            _hostingEnvironment = hostingEnvironment;

        }

        public IConfiguration Configuration { get; }
        public readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment _hostingEnvironment;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddScoped(typeof(IService<>), typeof(Service<>));
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IReportRepository, ReportRepository>();
            services.AddScoped<IReportService, ReportService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IMailService, MailService>();
            services.AddScoped<IXReportBLL, XReportBLL>();
            services.AddScoped<ISqlDataAccess, SqlDataAccess>();


          
            services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));
            services.AddAutoMapper(typeof(MyMapper));

            services.AddDbContext<Layer.Core.Models.TÝGER3Context>(options =>
              options.UseSqlServer(Configuration.GetConnectionString("DbLOGO")));

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
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Report}/{action=XReport}/{id?}");
            });
        }
    }
}

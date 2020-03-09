using System;
using Amazon.Runtime;
using Amazon.SimpleEmail;
using Mail_API.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Swashbuckle.Swagger;
using Microsoft.EntityFrameworkCore;
using Mail_API.Models.Db;
using IAmazonSimpleEmailService = Amazon.SimpleEmail.IAmazonSimpleEmailService;


namespace Mail_API
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
            services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo()); });
            services.AddDbContext<MailDbContext>(opts =>
                opts.UseSqlServer(Configuration.GetConnectionString("sqlConnection")));
            services.AddSingleton<FileContentResult>(new FileContentResult(
                Convert.FromBase64String(this.Configuration.GetValue<String>("Response:PixelContentBase64")),
                this.Configuration.GetValue<String>("Response:PixelContentType")
        ));
            services.AddScoped<EmailService>();
            services.AddControllers(); 
            services.AddMvc();
}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            loggerFactory.AddFile("Logs/Mail-Api-{Date}.txt");

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Test API V1");
            });


        }
    }
}

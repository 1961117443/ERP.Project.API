using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Admin.IService;
using Admin.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore;
using Swashbuckle.AspNetCore.Swagger;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac.Extras.DynamicProxy;
using Admin.Api.AOP;
using AutoMapper;

namespace Admin.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddAutoMapper(typeof(Startup));

            #region swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v0.1.0",
                    Title = "ERP Project API",
                    Description = "框架说明文档",
                    TermsOfService = "None",
                    Contact = new Contact { Name = "ERP.Project", Email = "1961117443@qq.com", Url = "https://github.com/1961117443" }
                });
                var basePath = Microsoft.DotNet.PlatformAbstractions.ApplicationEnvironment.ApplicationBasePath;
                var dirPath = Path.Combine(basePath, "XmlNotes");
                if (Directory.Exists(dirPath))
                {
                    DirectoryInfo dir = new DirectoryInfo(dirPath);
                    foreach (FileInfo file in dir.GetFiles("*.xml", SearchOption.TopDirectoryOnly))
                    {
                        c.IncludeXmlComments(file.FullName, true);//默认的第二个参数是false，这个是controller的注释，记得修改
                    }
                }
                
                //var xmlPath = Path.Combine(basePath, "Admin.Api.xml");//这个就是刚刚配置的xml文件名
                //c.IncludeXmlComments(xmlPath, true);//默认的第二个参数是false，这个是controller的注释，记得修改
            });
            #endregion

            #region AutoFac
            //实例化 autofac 容器
            var builder = new ContainerBuilder();

            //先注册拦截器 再注册接口
            builder.RegisterType(typeof(AdminLogAOP));

            //注册要通过反射创建的组件
            builder.RegisterType<CustomerService>().AsImplementedInterfaces()
                .InstancePerLifetimeScope()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(AdminLogAOP));


            //将services 填充 autofac 容器生成器
            builder.Populate(services);

            var applicationContainer = builder.Build();
            #endregion

            return new AutofacServiceProvider(applicationContainer);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            #region swagger
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "ApiHelp V1");
                c.RoutePrefix = "";
            });

            #endregion
            app.UseMvc();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GrabTemplate.Core.Interfaces;
using GrabTemplate.Core.Services;
using GrabTemplate.Domain;
using GrabTemplate.Infrastructure;
using GrabTemplate.Infrastructure.Interfaces;
using GrabTemplate.Infrastructure.Repositories;
using GrabTemplate.Misc.Enum;
using GrabTemplate.Misc.Helper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace GrabTemplate.Api
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
            services.AddDbContext<GrabTemplateContext>(options =>
                options.UseNpgsql(Configuration["ConnectionStrings:GrabTemplateConnection"]));

            services
                .AddScoped<IRepositoryAsync<LangDetail>, Repository<LangDetail>>()
                .AddScoped<IRepositoryAsync<Lang>, Repository<Lang>>()
                .AddScoped<IRepositoryAsync<Setting>, Repository<Setting>>()
                .AddScoped<IRepositoryAsync<SysUser>, Repository<SysUser>>()
                .AddScoped<IRepositoryAsync<Template>, Repository<Template>>()
                .AddScoped<IRepositoryAsync<EmailTemplate>, Repository<EmailTemplate>>()
                .AddScoped<IRepositoryAsync<Category>, Repository<Category>>()
                .AddScoped<IRepositoryAsync<Color>, Repository<Color>>()
                .AddScoped<IRepositoryAsync<LangMsgDetail>, Repository<LangMsgDetail>>()
                .AddScoped<IRepositoryAsync<DownloadToken>, Repository<DownloadToken>>()
                .AddScoped<IRepositoryAsync<Source>, Repository<Source>>()
                .AddScoped<IRepositoryAsync<Author>, Repository<Author>>()
                .AddScoped<IRepositoryAsync<OriginalTheme>, Repository<OriginalTheme>>()
                .AddScoped<IRepositoryAsync<Subscriber>, Repository<Subscriber>>()
                .AddScoped<IRepositoryAsync<TemplateColor>, Repository<TemplateColor>>()

                .AddScoped<IUnitOfWorkAsync, UnitOfWork>()
                .AddScoped<IDataContextAsync, GrabTemplateContext>();

            services.AddDistributedMemoryCache();
            services.AddAutoMapper();
            services
                .AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddJsonOptions(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddSession();

            services
                .AddTransient<ILangService, LangService>()
                .AddTransient<ILangDetailService, LangDetailService>()
                .AddTransient<ISysUserService, SysUserService>()
                .AddTransient<ISettingService, SettingService>()
                .AddTransient<ITemplateService, TemplateService>()
                .AddTransient<IEmailTemplateService, EmailTemplateService>()
                .AddTransient<ICategoryService, CategoryService>()
                .AddTransient<ILangMsgDetailService, LangMsgDetailService>()
                .AddTransient<IColorService, ColorService>()
                .AddTransient<IDownloadTokenService, DownloadTokenService>()
                .AddTransient<IAuthorService, AuthorService>()
                .AddTransient<ISourceService, SourceService>()
                .AddTransient<IOriginalThemeService, OriginalThemeService>()
                .AddTransient<ISubscriberService, SubscriberService>()
                .AddTransient<ITemplateColorService, TemplateColorService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();

            LoadLangDetail(serviceProvider);
            LoadSetting(serviceProvider);
        }

        private void LoadSetting(IServiceProvider serviceProvider)
        {
            GrabTemplateSetting.IsOnMaintenance = bool.Parse(((SettingService)serviceProvider.GetService(typeof(ISettingService))).Queryable().FirstOrDefault(x => x.Name == "IsOnMaintenance").Value);
            GrabTemplateSetting.IsEarningMoneyActivated = bool.Parse(((SettingService)serviceProvider.GetService(typeof(ISettingService))).Queryable().FirstOrDefault(x => x.Name == "IsEarningMoneyActivated").Value);
        }

        private void LoadLangDetail(IServiceProvider serviceProvider)
        {
            LangDetailHelper.LangDetails = ((LangDetailService)serviceProvider.GetService(typeof(ILangDetailService))).Queryable().Select(x => Mapper.Map<LangDetailViewModel>(x)).ToList();
        }
    }
}

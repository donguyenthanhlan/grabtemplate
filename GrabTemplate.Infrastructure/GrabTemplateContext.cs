using Microsoft.EntityFrameworkCore;
using System;
using GrabTemplate.Domain;
using GrabTemplate.Infrastructure.Repositories;
using GrabTemplate.Mapping;

namespace GrabTemplate.Infrastructure
{
    public class GrabTemplateContext : DataContext
    {
        public GrabTemplateContext(DbContextOptions<GrabTemplateContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Lang> Lang { get; set; }
        public DbSet<LangDetail> LangDetail { get; set; }
        public DbSet<LangMsgDetail> LangMsgDetail { get; set; }
        public DbSet<Template> Template { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<DownloadToken> DownloadToken { get; set; }
        public DbSet<TemplateColor> TemplateColor { get; set; }
        public DbSet<SysUser> SysUser { get; set; }
        public DbSet<Setting> Setting { get; set; }
        public DbSet<EmailTemplate> EmailTemplate { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Source> Source { get; set; }
        public DbSet<OriginalTheme> OriginalTheme { get; set; }
        public DbSet<Subscriber> Subscriber { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new LangMap());
            modelBuilder.ApplyConfiguration(new LangDetailMap());
            modelBuilder.ApplyConfiguration(new LangMsgDetailMap());
            modelBuilder.ApplyConfiguration(new TemplateMap());
            modelBuilder.ApplyConfiguration(new ColorMap());
            modelBuilder.ApplyConfiguration(new DownloadTokenMap());
            modelBuilder.ApplyConfiguration(new TemplateColorMap());
            modelBuilder.ApplyConfiguration(new SysUserMap());
            modelBuilder.ApplyConfiguration(new SettingMap());
            modelBuilder.ApplyConfiguration(new EmailTemplateMap());
            modelBuilder.ApplyConfiguration(new OriginalThemeMap());
            modelBuilder.ApplyConfiguration(new SubscriberMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}

using System;
using System.Collections.Generic;
using GrabTemplate.Common.Models;

namespace GrabTemplate.Domain
{
    public class Template : Entity
    {
        public int Id { get; set; }
        public string Title{ get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ListingImage { get; set; }
        public string SlideImage { get; set; }
        public string DetailImages { get; set; }
        public int CategoryId { get; set; }
        public int SourceId { get; set; }
        public int AuthorId { get; set; }
        public double Rate { get; set; }
        public int ReviewCount { get; set; }
        public string ShortDescription { get; set; }
        public string DemoUrl { get; set; }
        public string BuyUrl { get; set; }
        public int OriginalThemeId { get; set; }
        public string CssFramework { get; set; }
        public int ViewCount { get; set; } 
        public int DownloadCount { get; set; }
        public bool IsResponsive { get; set; }
        public string Tags { get; set; }
        public bool IsBestSelling { get; set; }
        public string DownloadUrl { get; set; }
        public string ShortDownloadUrl { get; set; }
        public string Palette { get; set; }

        public virtual Source Source { get; set; }
        public virtual Category Category { get; set; }
        public virtual Author Author { get; set; }
        public virtual OriginalTheme OriginalTheme { get; set; }
        public virtual ICollection<TemplateColor> TemplateColors { get; set; }
    }
}

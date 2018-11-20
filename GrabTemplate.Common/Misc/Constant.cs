using System;
using System.Collections.Generic;
using System.Text;

namespace GrabTemplate.Common.Misc
{
    public class Constant
    {
        //Authentication
        public static string ActivateExpiredInDays = "ActivateExpiredInDays";
        public static string ResetPasswordExpiredInDays = "ResetPasswordExpiredInDays";

        //Home
        public static string BestSellingIntervalInWeeks = "BestSellingIntervalInWeeks";
        public static string TrendIntervalInWeeks = "TrendIntervalInWeeks";
        public static string LatestIntervalInWeeks = "LatestIntervalInWeeks";
        public static string BestSellingItemCount = "BestSellingItemCount";
        public static string TrendItemCount = "TrendItemCount";
        public static string LatestItemCount = "LatestItemCount";
        public static string HomeSlideCount = "HomeSlideCount";
        public static string SimilarTemplateCount = "SimilarTemplateCount";
        public static string SameCategoryTemplateCount = "SameCategoryTemplateCount";

        //Category
        public static string FullListingTemplatePageSize = "FullListingTemplatePageSize";

        public struct SMTP
        {
            public static string Host = "smtp.elasticemail.com";
            public static int Port = 2525;
            public static bool IsSSLEnable = true;
            public static string Email = "bdo@netsservices.dk";
            public static string From = "info@templatekul.com";
            public static string Username = "bdo@netsservices.dk";
            public static string Password = "33e6c440-459c-4ea2-b30f-c6de705f4bf0";
        }

        public struct ShortenLink
        {
            public static string Url = "https://petty.link/api?api=311b9e5936b76afddaa6dd6598e9e04e9bbd268f&url={0}&alias=templatepik{1}{2}";
            public static string Default = "#";
        }

        public struct Maintenance
        {
            public static char MaintenanceAllowedIpDelimiter { get; set; } = ';';
            public static string MaintenanceAllowedIp { get; set; } = "14.161.32.23" + MaintenanceAllowedIpDelimiter + "::1";
        }

        public static string CipherPassword = "gtbindo";

        public struct DisplayFormat
        {
            public static string Integer = "N0";
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrabTemplate.Common.Misc;
using GrabTemplate.Misc.Enum;
using GrabTemplate.Misc.Extension;
using GrabTemplate.Models;

namespace GrabTemplate.Misc
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    public class PermissionAttribute : ActionFilterAttribute
    {
        public EnumRole Role { get; set; }
        public PermissionAttribute(EnumRole role)
        {
            this.Role = role;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if ((context.RouteData.Values["action"].ToString() == "Maintenance") && (context.RouteData.Values["controller"].ToString() == "Home"))
            {
                base.OnActionExecuting(context);
                return;
            }

            var user = context.HttpContext.Session.GetObjectFromJson<SysUserViewModel>("CurrentUser");
            var remoteIp = context.HttpContext.Connection.RemoteIpAddress.ToString();
            if (GrabTemplateSetting.IsOnMaintenance && !Constant.Maintenance.MaintenanceAllowedIp.Split(Constant.Maintenance.MaintenanceAllowedIpDelimiter).Contains(remoteIp))
            {
                context.Result = new RedirectResult("/Home/Maintenance");
            }
            else if (Role == EnumRole.User && user == null)
                context.Result = new RedirectResult("/Authentication/LogIn");
            else if (Role == EnumRole.Admin && user == null)
                context.Result = new RedirectResult("/Authentication/LogIn");
            else if (Role == EnumRole.Admin && user != null && !user.IsAdmin)
                context.Result = new RedirectResult("/Error/Error403");
            base.OnActionExecuting(context);
        }
    }
}

﻿using Microsoft.AspNetCore.Http;
using System;

namespace GrabTemplate.Misc
{
    public static class GrabTemplateCookie
    {
        public static object Response { get; private set; }

        /// <summary>  
        /// set the cookie  
        /// </summary>  
        /// <param name="key">key (unique indentifier)</param>  
        /// <param name="value">value to store in cookie object</param>  
        /// <param name="expireTime">expiration time</param>  
        public static void SetCookies(HttpResponse Response, string key, string value, int? expireTime)
        {
            CookieOptions option = new CookieOptions();

            if (expireTime.HasValue)
                option.Expires = DateTime.Now.AddMinutes(expireTime.Value);
            else
                option.Expires = DateTime.Now.AddMilliseconds(10);

            Response.Cookies.Append(key, value, option);
        }

        /// <summary>  
        /// Delete the key  
        /// </summary>  
        /// <param name="key">Key</param>  
        public static void RemoveCookies(HttpResponse Response, string key)
        {
            Response.Cookies.Delete(key);
        }
    }
}

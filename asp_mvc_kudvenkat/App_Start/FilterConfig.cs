﻿using System.Web;
using System.Web.Mvc;

namespace asp_mvc_kudvenkat
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

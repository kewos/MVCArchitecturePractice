using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(MVCArchitecturePractice.Web.App_Start.WebCommon), "Start")]

namespace MVCArchitecturePractice.Web.App_Start
{
    public static class WebCommon
    {
        public static void start()
        { 
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIB.ExtentionMethods;
using Kajal.Com.Helpers;



namespace Kajal.Com.Helpers.UrlHelperExtensions
{
    public static class Extensions
    {
        

    }
}

namespace Kajal.Com.Helpers
{
    public class PathHelper : LIB.UrlHelper
    {
        public enum Url
        {
            url_Web,
            url_Admin,
            url_Static,
            url_Google_Analytics_AppName,
            url_Google_Analytics_UserName,
            url_Google_Analytics_AppKey,
            url_Google_Analytics_ProfileId,
            url_Google_Analytics_AccountId,
            url_Google_Analytics_Password
        }

        public static string UrlWeb { get { return LIB.Util.GetConfigValue(Url.url_Web.ToString()); } }
        public static string UrlAdmin { get { return LIB.Util.GetConfigValue(Url.url_Admin.ToString()); } }
        public static string UrlStatic { get { return LIB.Util.GetConfigValue(Url.url_Static.ToString()); } }
        public static string Google_Analytics_AppName { get { return LIB.Util.GetConfigValue(Url.url_Google_Analytics_AppName.ToString()); } }
        public static string Google_Analytics_UserName { get { return LIB.Util.GetConfigValue(Url.url_Google_Analytics_UserName.ToString()); } }
        public static string Google_Analytics_AppKey { get { return LIB.Util.GetConfigValue(Url.url_Google_Analytics_AppKey.ToString()); } }
        public static string Google_Analytics_ProfileId { get { return LIB.Util.GetConfigValue(Url.url_Google_Analytics_ProfileId.ToString()); } }
        public static string Google_Analytics_AccountId { get { return LIB.Util.GetConfigValue(Url.url_Google_Analytics_AccountId.ToString()); } }
        public static string Google_Analytics_Password { get { return LIB.Util.GetConfigValue(Url.url_Google_Analytics_Password.ToString()); } }

        public class Images
        {

        }
    }
}
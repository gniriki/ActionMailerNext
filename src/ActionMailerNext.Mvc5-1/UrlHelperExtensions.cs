﻿using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ActionMailerNext.Mvc5_1
{
    /// <summary>
    ///     Simple extension methods for UrlHelper to always generate absolute urls.
    /// </summary>
    public static class UrlHelperExtensions
    {
        /// <summary>
        ///     Generates an absolute url for the provided action.
        /// </summary>
        /// <param name="helper">The UrlHelper instance to use for generation.</param>
        /// <param name="actionName">The name of the action.</param>
        /// <returns>An absolute url.</returns>
        public static string AbsoluteAction(this UrlHelper helper, string actionName)
        {
            string url = String.Empty;
            //try
            //{
            url = helper.Action(actionName);

            //}
            //catch (ArgumentNullException e)
            //{

            //    Debug.WriteLine(e.Source);
            //}

            return GetAbsoluteUrl(helper.RequestContext.HttpContext.Request, url).ToString();
        }

        /// <summary>
        ///     Generates an absolute url for the provided action.
        /// </summary>
        /// <param name="helper">The UrlHelper instance to use for generation.</param>
        /// <param name="actionName">The name of the action.</param>
        /// <param name="controllerName">The name of the controller.</param>
        /// <returns>An absolute url.</returns>
        public static string AbsoluteAction(this UrlHelper helper, string actionName, string controllerName)
        {
            string url = helper.Action(actionName, controllerName);
            return GetAbsoluteUrl(helper.RequestContext.HttpContext.Request, url).ToString();
        }

        /// <summary>
        ///     Generates an absolute url for the provided action.
        /// </summary>
        /// <param name="helper">The UrlHelper instance to use for generation.</param>
        /// <param name="actionName">The name of the action.</param>
        /// <param name="routeValues">Any extra route values you wish to use for generation.</param>
        /// <returns>An absolute url.</returns>
        public static string AbsoluteAction(this UrlHelper helper, string actionName, object routeValues)
        {
            string url = helper.Action(actionName, routeValues);
            return GetAbsoluteUrl(helper.RequestContext.HttpContext.Request, url).ToString();
        }

        /// <summary>
        ///     Generates an absolute url for the provided action.
        /// </summary>
        /// <param name="helper">The UrlHelper instance to use for generation.</param>
        /// <param name="actionName">The name of the action.</param>
        /// <param name="routeValues">Any extra route values you wish to use for generation.</param>
        /// <returns>An absolute url.</returns>
        public static string AbsoluteAction(this UrlHelper helper, string actionName, RouteValueDictionary routeValues)
        {
            string url = helper.Action(actionName, routeValues);
            return GetAbsoluteUrl(helper.RequestContext.HttpContext.Request, url).ToString();
        }

        /// <summary>
        ///     Generates an absolute url for the provided action.
        /// </summary>
        /// <param name="helper">The UrlHelper instance to use for generation.</param>
        /// <param name="actionName">The name of the action.</param>
        /// <param name="controllerName">The name of the controller.</param>
        /// <param name="routeValues">Any extra route values you wish to use for generation.</param>
        /// <returns>An absolute url.</returns>
        public static string AbsoluteAction(this UrlHelper helper, string actionName, string controllerName,
            object routeValues)
        {
            string url = helper.Action(actionName, controllerName, routeValues);
            return GetAbsoluteUrl(helper.RequestContext.HttpContext.Request, url).ToString();
        }

        /// <summary>
        ///     Generates an absolute url for the provided action.
        /// </summary>
        /// <param name="helper">The UrlHelper instance to use for generation.</param>
        /// <param name="actionName">The name of the action.</param>
        /// <param name="controllerName">The name of the controller.</param>
        /// <param name="routeValues">Any extra route values you wish to use for generation.</param>
        /// <returns>An absolute url.</returns>
        public static string AbsoluteAction(this UrlHelper helper, string actionName, string controllerName,
            RouteValueDictionary routeValues)
        {
            string url = helper.Action(actionName, controllerName, routeValues);
            return GetAbsoluteUrl(helper.RequestContext.HttpContext.Request, url).ToString();
        }

        /// <summary>
        ///     Generates an absolute url for the provided action.
        /// </summary>
        /// <param name="helper">The UrlHelper instance to use for generation.</param>
        /// <param name="actionName">The name of the action.</param>
        /// <param name="controllerName">The name of the controller.</param>
        /// <param name="routeValues">Any extra route values you wish to use for generation.</param>
        /// <param name="protocol">The protocol to use (http or https usually).</param>
        /// <returns>An absolute url.</returns>
        public static string AbsoluteAction(this UrlHelper helper, string actionName, string controllerName,
            object routeValues, string protocol)
        {
            string url = helper.Action(actionName, controllerName, routeValues, protocol);
            return GetAbsoluteUrl(helper.RequestContext.HttpContext.Request, url).ToString();
        }

        /// <summary>
        ///     Generates an absolute url for the provided action.
        /// </summary>
        /// <param name="helper">The UrlHelper instance to use for generation.</param>
        /// <param name="actionName">The name of the action.</param>
        /// <param name="controllerName">The name of the controller.</param>
        /// <param name="routeValues">Any extra route values you wish to use for generation.</param>
        /// <param name="protocol">The protocol to use (http or https usually).</param>
        /// <param name="hostName">The host name to use.</param>
        /// <returns>An absolute url.</returns>
        public static string AbsoluteAction(this UrlHelper helper, string actionName, string controllerName,
            RouteValueDictionary routeValues, string protocol, string hostName)
        {
            string url = helper.Action(actionName, controllerName, routeValues, protocol, hostName);
            return GetAbsoluteUrl(helper.RequestContext.HttpContext.Request, url).ToString();
        }

        /// <summary>
        ///     Generates an absolute url for the provided route.
        /// </summary>
        /// <param name="helper">The UrlHelper instance to use for generation.</param>
        /// <param name="routeValues">Any extra route values you wish to use for generation.</param>
        /// <returns></returns>
        public static string AbsoluteRouteUrl(this UrlHelper helper, object routeValues)
        {
            string url = helper.RouteUrl(routeValues);
            return GetAbsoluteUrl(helper.RequestContext.HttpContext.Request, url).ToString();
        }

        /// <summary>
        ///     Generates an absolute url for the provided route.
        /// </summary>
        /// <param name="helper">The UrlHelper instance to use for generation.</param>
        /// <param name="routeName">The name of the route to use.</param>
        /// <returns>An absolute url.</returns>
        public static string AbsoluteRouteUrl(this UrlHelper helper, string routeName)
        {
            string url = helper.RouteUrl(routeName);
            return GetAbsoluteUrl(helper.RequestContext.HttpContext.Request, url).ToString();
        }

        /// <summary>
        ///     Generates an absolute url for the provided route.
        /// </summary>
        /// <param name="helper">The UrlHelper instance to use for generation.</param>
        /// <param name="routeValues">Any extra route values you wish to use for generation.</param>
        /// <returns>An absolute url.</returns>
        public static string AbsoluteRouteUrl(this UrlHelper helper, RouteValueDictionary routeValues)
        {
            string url = helper.RouteUrl(routeValues);
            return GetAbsoluteUrl(helper.RequestContext.HttpContext.Request, url).ToString();
        }

        /// <summary>
        ///     Generates an absolute url for the provided route.
        /// </summary>
        /// <param name="helper">The UrlHelper instance to use for generation.</param>
        /// <param name="routeName">The name of the route to use.</param>
        /// <param name="routeValues">Any extra route values you wish to use for generation.</param>
        /// <returns>An absolute url.</returns>
        public static string AbsoluteRouteUrl(this UrlHelper helper, string routeName, object routeValues)
        {
            string url = helper.RouteUrl(routeName, routeValues);
            return GetAbsoluteUrl(helper.RequestContext.HttpContext.Request, url).ToString();
        }

        /// <summary>
        ///     Generates an absolute url for the provided route.
        /// </summary>
        /// <param name="helper">The UrlHelper instance to use for generation.</param>
        /// <param name="routeName">The name of the route to use.</param>
        /// <param name="routeValues">Any extra route values you wish to use for generation.</param>
        /// <returns>An absolute url.</returns>
        public static string AbsoluteRouteUrl(this UrlHelper helper, string routeName, RouteValueDictionary routeValues)
        {
            string url = helper.RouteUrl(routeName, routeValues);
            return GetAbsoluteUrl(helper.RequestContext.HttpContext.Request, url).ToString();
        }

        /// <summary>
        ///     Generates an absolute url for the provided route.
        /// </summary>
        /// <param name="helper">The UrlHelper instance to use for generation.</param>
        /// <param name="routeName">The name of the route to use.</param>
        /// <param name="routeValues">Any extra route values you wish to use for generation.</param>
        /// <param name="protocol">The protocol to use (http or https usually).</param>
        /// <returns>An absolute url.</returns>
        public static string AbsoluteRouteUrl(this UrlHelper helper, string routeName, object routeValues,
            string protocol)
        {
            string url = helper.RouteUrl(routeName, routeValues, protocol);
            return GetAbsoluteUrl(helper.RequestContext.HttpContext.Request, url).ToString();
        }

        /// <summary>
        ///     Generates an absolute url for the provided virtual content path.
        /// </summary>
        /// <param name="helper">The UrlHelper instance to use for generation.</param>
        /// <param name="contentPath">The virtual path of the content.</param>
        /// <returns></returns>
        public static string AbsoluteContent(this UrlHelper helper, string contentPath)
        {
            string url = helper.Content(contentPath);
            return GetAbsoluteUrl(helper.RequestContext.HttpContext.Request, url).ToString();
        }

        /// <summary>
        ///     Generates an absolute url for the provided route.
        /// </summary>
        /// <param name="helper">The UrlHelper instance to use for generation.</param>
        /// <param name="routeName">The name of the route to use.</param>
        /// <param name="routeValues">Any extra route values you wish to use for generation.</param>
        /// <param name="protocol">The protocol to use (http or https usually).</param>
        /// <param name="hostName">The host name to use.</param>
        /// <returns>An absolute url.</returns>
        public static string AbsoluteRouteUrl(this UrlHelper helper, string routeName, RouteValueDictionary routeValues,
            string protocol, string hostName)
        {
            string url = helper.RouteUrl(routeName, routeValues, protocol, hostName);
            return GetAbsoluteUrl(helper.RequestContext.HttpContext.Request, url).ToString();
        }

        private static Uri GetAbsoluteUrl(HttpRequestBase request, string url)
        {
            var uri = new Uri(url, UriKind.RelativeOrAbsolute);
            if (uri.IsAbsoluteUri)
                return uri;

            url = String.Format("{0}{1}", request.Url.GetLeftPart(UriPartial.Authority), url);
            return new Uri(url);
        }
    }
}
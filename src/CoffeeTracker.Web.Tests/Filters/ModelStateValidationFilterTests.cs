using System.Collections.Generic;
using CoffeeTracker.Web.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Xunit;

namespace CoffeeTracker.Web.Tests.Filters
{
    public class ModelStateValidationFilterTests
    {
        //[Fact]
        //public void InvalidModelShouldReturnBadRequestObjectResult()
        //{
        //    var actionContext = new ActionContext(new DefaultHttpContext(), new RouteData(), new ActionDescriptor());
        //    var context = new ActionExecutingContext(actionContext, new List<IFilterMetadata>(), new Dictionary<string, object>(), null);
        //    var filter = new ModelStateValidationFilter();

        //    filter.OnActionExecuting(context);

        //    Assert.True(context.Result is BadRequestObjectResult);
        //}

        //[Fact]
        //public void ValidModelShouldReturnView()
        //{
        //    var actionContext = new ActionContext(new DefaultHttpContext(), new RouteData(), new ActionDescriptor());
        //    var context = new ActionExecutingContext(actionContext, new List<IFilterMetadata>(), new Dictionary<string, object>(), null);
        //    var filter = new ModelStateValidationFilter();

        //    filter.OnActionExecuting(context);

        //    Assert.True(context.Result is ViewResult);
        //}
    }
}
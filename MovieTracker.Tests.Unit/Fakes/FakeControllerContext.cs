using System.Web;
using System.Web.Mvc;
using MovieTracker.Tests.Unit.Controllers;

namespace MovieTracker.Tests.Unit.Fakes
{
    public class FakeControllerContext : ControllerContext
    {
        public override HttpContextBase HttpContext
        {
            get { return new FakeHttpContext(); }
            set { base.HttpContext = value; }
        }
    }
}
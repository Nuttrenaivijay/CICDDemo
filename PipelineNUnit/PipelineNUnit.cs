using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using PipelineDemo.Pages;
using System;

namespace RazorPagesTests
{
    public class ErrorModelTests
    {
        [Test]
        public void ErrorModel_Should_Set_RequestId_When_Provided()
        {
            var logger = new LoggerFactory().CreateLogger<ErrorModel>();
            var model = new ErrorModel(logger)
            {
                RequestId = "ABC123"
            };

            Assert.IsTrue(model.ShowRequestId);
            Assert.AreEqual("ABC123", model.RequestId);
        }

        [Test]
        public void ErrorModel_Should_Not_Show_RequestId_When_Null()
        {
            var logger = new LoggerFactory().CreateLogger<ErrorModel>();
            var model = new ErrorModel(logger)
            {
                RequestId = null
            };

            Assert.IsFalse(model.ShowRequestId);
        }
    }

    //public class IndexModelTests
    //{
    //    [Test]
    //    public void IndexModel_Should_Set_Title_Correctly()
    //    {
    //        var model = new IndexModel();
    //        Assert.AreEqual("Home page", model.ViewData["Title"]);
    //    }
    //}

    //public class PrivacyModelTests
    //{
    //    [Test]
    //    public void PrivacyModel_Should_Set_Title_Correctly()
    //    {
    //        var model = new PrivacyModel();
    //        Assert.AreEqual("Privacy Policy", model.ViewData["Title"]);
    //    }
    //}
}

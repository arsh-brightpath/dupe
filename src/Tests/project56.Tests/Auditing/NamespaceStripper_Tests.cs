using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project56.Auditing;
using Shouldly;
using Xunit;

namespace project56.Tests.Auditing
{
    public class NamespaceStripper_Tests: AppTestBase
    {
        private readonly INamespaceStripper _namespaceStripper;

        public NamespaceStripper_Tests()
        {
            _namespaceStripper = Resolve<INamespaceStripper>();
        }

        [Fact]
        public void Should_Stripe_Namespace()
        {
            var controllerName = _namespaceStripper.StripNameSpace("project56.Web.Controllers.HomeController");
            controllerName.ShouldBe("HomeController");
        }

        [Theory]
        [InlineData("project56.Auditing.GenericEntityService`1[[project56.Storage.BinaryObject, project56.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null]]", "GenericEntityService<BinaryObject>")]
        [InlineData("CompanyName.ProductName.Services.Base.EntityService`6[[CompanyName.ProductName.Entity.Book, CompanyName.ProductName.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[CompanyName.ProductName.Services.Dto.Book.CreateInput, N...", "EntityService<Book, CreateInput>")]
        [InlineData("project56.Auditing.XEntityService`1[project56.Auditing.AService`5[[project56.Storage.BinaryObject, project56.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[project56.Storage.TestObject, project56.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],]]", "XEntityService<AService<BinaryObject, TestObject>>")]
        public void Should_Stripe_Generic_Namespace(string serviceName, string result)
        {
            var genericServiceName = _namespaceStripper.StripNameSpace(serviceName);
            genericServiceName.ShouldBe(result);
        }
    }
}

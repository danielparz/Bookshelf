using Bookshelf.App.Abstract;
using Bookshelf.App.Concrete;
using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Bookshelf.Tests
{
    public class MenuActionServiceUnitTest
    {
        [Fact]
        public void InitializeTest()
        {
            MenuActionService menuActionService = new MenuActionService();

            menuActionService.Should().NotBeNull();
            menuActionService.GetMenuActionByMenuName("Main").Count.Should().Be(4);
            menuActionService.GetMenuActionByMenuName("BookShow").Count.Should().Be(5);
            menuActionService.GetMenuActionByMenuName("BookEdit").Count.Should().Be(2);
        }
    }
}

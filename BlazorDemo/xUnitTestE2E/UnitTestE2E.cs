using BlazorDemo.Pages;
using Bunit;
using Xunit;
using Telerik.JustMock;

namespace UnitTestE2E
{
    [System.Obsolete]
    public class TestCalculatorTest : ComponentTestFixture
    {
        [Fact]
        public void TestCalculator()
        {
            // Arrange
            var cut = RenderComponent<Calculator>();
            cut.Find("p").MarkupMatches("<p>First Number</p>");

            // Act
            var element = cut.Find("Add (+)");
            element.Click();

            //Assert
            cut.Find("p").MarkupMatches("<p>First Number</p>");
        }
    }
}

using Microsoft.Extensions.Configuration;
using WildConsulting.WebSite.Core.Pages;

namespace WildConsulting.WebSite.Core.Tests;

public class IndexModelTests
{
    private const string TestEmailAddress = "my.email@test.com";

    private readonly Mock<IConfiguration> _mockConfiguration;

    public IndexModelTests()
    {
        _mockConfiguration = new Mock<IConfiguration>();
        _mockConfiguration
            .SetupGet(x => x["ContactSettings:Email"])
            .Returns(TestEmailAddress);
    }

    [Fact]
    public void IndexModel_Should_Read_Contact_Email_From_Configuration()
    {
        var pageModel = new IndexModel(_mockConfiguration.Object);

        pageModel.Email.ShouldBe(TestEmailAddress);
    }
}

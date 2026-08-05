using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WildConsulting.WebSite.Core.Pages;

public class IndexModel(IConfiguration configuration) : PageModel
{
    public string Email { get; } = configuration["ContactSettings:Email"] ?? string.Empty;
}

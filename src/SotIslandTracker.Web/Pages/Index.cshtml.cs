using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SotIslandTracker.Web.Pages;

public class Index : PageModel
{
    private readonly ILogger<Index> _logger;

    public Index(ILogger<Index> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}
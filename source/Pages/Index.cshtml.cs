using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Public_CTF_Web.Pages;

[ResponseCache(Duration = 60, Location = ResponseCacheLocation.Any, NoStore = false)]
public class IndexModel : PageModel
{
    public static ListChallenges listChallenges = new ListChallenges(
        Path.Combine(Directory.GetCurrentDirectory(), "Pages", "challenges", "challenges.json")
    );
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

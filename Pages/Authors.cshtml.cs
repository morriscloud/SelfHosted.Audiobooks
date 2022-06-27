using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SelfHosted.Audiobooks.Pages;

public class AuthorsModel : PageModel
{
    private readonly ILogger<AuthorsModel> logger;

    public AuthorsModel(ILogger<AuthorsModel> logger)
    {
        this.logger = logger;
    }

    public void OnGet()
    {

    }
}

using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SelfHosted.Audiobooks.Pages;

public class BooksModel : PageModel
{
    private readonly ILogger<BooksModel> logger;

    public BooksModel(ILogger<BooksModel> logger)
    {
        this.logger = logger;
    }

    public void OnGet()
    {

    }
}

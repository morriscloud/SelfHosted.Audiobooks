using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SelfHosted.Audiobooks.Pages;

public class SeriesModel : PageModel
{
    private readonly ILogger<SeriesModel> logger;

    public SeriesModel(ILogger<SeriesModel> logger)
    {
        this.logger = logger;
    }

    public void OnGet()
    {

    }
}

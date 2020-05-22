using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace RazorPages.Pages
{
  public class OptimizerModel : PageModel
  {
    [BindProperty]
    public string Title { get; set; }

    public void OnGet() {
      this.Title = "Optimizer";
    }
  }
}


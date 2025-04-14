using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GitHub_PRCI_Demo.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public float? Weight { get; set; }

    [BindProperty]
    public float? Height { get; set; }

    public float? BMI { get; private set; }

    public void OnPost()
    {
        if (Weight.HasValue && Height.HasValue && Height > 0)
        {
            int para1=12;

            para1=para1/0;
            Height=(int)Height / 100; // Convert height from cm to m
            BMI = Weight / (Height * Height);
            //todo: 尚未完成
        }
    }
}

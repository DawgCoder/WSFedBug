using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly LoginService _loginService;

        public IndexModel(ILogger<IndexModel> logger, LoginService loginService)
        {
            _logger = logger;
            _loginService = loginService;
        }

        public void OnGet()
        {
        }

        public void OnPost() 
        {
            Login();
        }
                
        public void Login()
        {
            _loginService.Login();
        }
    }
}

using Court4U_PRN.Data;
using Court4U_PRN.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Court4U_PRN.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly Court4UDbContext _context;
        public string hello = "welcome";
        public List<Club> clubs = [];
        public IndexModel(Court4UDbContext context)
        {
            _context = context;
        }
        public async Task OnGetAsync()
        {
            hello = "welcome2";
            clubs = await _context.Clubs.ToListAsync();
        }
    }
}

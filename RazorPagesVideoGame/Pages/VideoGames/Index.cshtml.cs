using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesVideoGame.Data;
using RazorPagesVideoGame.Models;

namespace RazorPagesVideoGame.Pages.VideoGames
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesVideoGame.Data.RazorPagesVideoGameContext _context;

        public IndexModel(RazorPagesVideoGame.Data.RazorPagesVideoGameContext context)
        {
            _context = context;
        }

        public IList<VideoGameModel> VideoGameModel { get;set; }

        public async Task OnGetAsync()
        {
            VideoGameModel = await _context.VideoGameModel.ToListAsync();
        }
    }
}

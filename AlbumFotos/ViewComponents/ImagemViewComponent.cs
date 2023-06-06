using AlbumFotos.Context;
using DocumentFormat.OpenXml.Office2021.DocumentTasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumFotos.ViewComponents
{
    public class ImagemViewComponent : ViewComponent
    {
        private readonly AlbumContext _context;

        public ImagemViewComponent(AlbumContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            return View(await _context.Imagens.Where(x => x.AlbumId == id).ToListAsync());
        }
    }
}

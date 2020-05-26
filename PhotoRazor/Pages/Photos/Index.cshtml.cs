using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PhotoRazor.Models;
using ServicePhotoAlbum;

namespace PhotoRazor
{
    public class PhotosModel : PageModel
    {
        FunctionsClient fc = new FunctionsClient();
        public List<PhotoDTO> Photos { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Camp { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Cauta { get; set; }
        public IList<string> Campuri;

        public PhotosModel()
        {
            Photos = new List<PhotoDTO>();
        }
        public async Task OnGetAsync()
        {
            var media = await fc.Afisare_MediaAsync();
            Campuri = await fc.Initializare_proprietatiAsync();
            media.Sort();
            int i = 0;
            foreach (var item in media)
            {
                var p = new PhotoDTO();
                p.Path = item;
                p.Id = i;
                i += 1;
                Photos.Add(p);
            }

        }
    }
}
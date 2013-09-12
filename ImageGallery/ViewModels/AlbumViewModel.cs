using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageGallery.ViewModels
{
    public class AlbumViewModel
    {
        public string Name { get; set; }
        public IEnumerable<ImageViewModel> Images { get; set; }

        public AlbumViewModel()
        {
            this.Images = new HashSet<ImageViewModel>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using System.Windows.Threading;
using ImageGallery.Commands;

namespace ImageGallery.ViewModels
{
    public class ImageAlbumGalaryViewModel:ViewModelBase
    {
        private IEnumerable<AlbumViewModel> albumsViewModels;

         public string AlbumsStoreDocumentPath { get; set; }

        public ImageAlbumGalaryViewModel()
        {
            this.AlbumsStoreDocumentPath = "..\\..\\..\\ImageGallery\\albums.xml";
        }

        //private IEnumerable<PhoneViewModel> phonesViewModels;

        public IEnumerable<AlbumViewModel> Albums
        {
            get
            {
                if (this.albumsViewModels == null)
                {
                    this.albumsViewModels = DataPersister.GetAll(AlbumsStoreDocumentPath);
                }
                return albumsViewModels;
            }
        }
    }
}

        

                    
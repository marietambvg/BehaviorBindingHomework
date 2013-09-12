using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Collections;

namespace ImageGallery.ViewModels
{
    public class DataPersister
    {
        public static IEnumerable<AlbumViewModel> GetAll(string albumsStoreDocumentPath)
        {
            var albumsDocumentRoot = XDocument.Load(albumsStoreDocumentPath).Root;

            var albumsVMs =
                           from albumElement in albumsDocumentRoot.Elements("album")
                           select new AlbumViewModel()
                           {
                               Name = albumElement.Element("name").Value,
                               Images = GetImagesInAlbum(albumElement.Element("images"))

                           };
            return albumsVMs;

        }
        public static IEnumerable<ImageViewModel> GetImagesInAlbum(XElement imagesElement)
        {
            var imagesVMs =
                           from imageElement in imagesElement.Elements("image")
                           select new ImageViewModel()
                           {
                               Title = imageElement.Element("title").Value,
                               ImageSource = imageElement.Element("imagesource").Value,

                           };
            return imagesVMs;
        }

    }
}
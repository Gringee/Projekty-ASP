namespace Laboratorium3.Models
{
    public class MemoryPhotoServices : IPhotoService
    {
        private readonly Dictionary<int, Photo> _photos= new Dictionary<int, Photo>()
        {

            {1, new Photo() {Id = 1, Data = new DateTime(2022, 5, 1, 8, 30, 0), Opis = "zdjecie z wakacji", Aparat = "Nikon", Autor="Grzegorz", Resolution = "1080p", Format="16x9"} },
            {2, new Photo() {Id = 2, Data = new DateTime(2023, 2, 10, 8, 50, 0), Opis = "zdjecie szkolne", Aparat = "Samsung", Autor="Paweł", Resolution = "720p", Format="4x3"} },
        };
        private int _id = 3;
        public void Add(Photo album)
        {
            album.Id = _id++;
            _photos[album.Id] = album;
        }

        public void DeleteById(Photo album)
        {
            _photos.Remove(album.Id);
        }

        public List<Photo> FindAll()
        {
            return _photos.Values.OrderBy(album => album.Opis).ToList();
        }

        public Photo? FindById(int id)
        {
            return _photos[id];
        }

        public void Update(Photo album)
        {
            _photos[album.Id] = album;
        }
    }
}


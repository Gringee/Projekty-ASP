namespace Laboratorium3.Models
{
    public interface IPhotoService
    {
        void Add(Photo album);
        void Update(Photo album);
        void DeleteById(Photo album);
        Photo? FindById(int id);
        List<Photo> FindAll();
    }
}

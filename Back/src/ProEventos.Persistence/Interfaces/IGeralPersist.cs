using System.Threading.Tasks;

namespace ProEventos.Persistence.Interfaces
{
    public interface IGeralPersist
    {
         void Add<T>(T entity) where T: class;
         void Update<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         void DeleteRange<T>(T[] entity) where T: class;
         Task <bool> SaveChangesAsync();
    }
}
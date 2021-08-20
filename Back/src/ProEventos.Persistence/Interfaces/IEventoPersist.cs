using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence.Interfaces
{
    public interface IEventoPersist
    {
         Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false);
         Task<Evento> GetEventoByIdAsync(int eventoId, bool includePalestrantes = false);
         Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false);
    }
}
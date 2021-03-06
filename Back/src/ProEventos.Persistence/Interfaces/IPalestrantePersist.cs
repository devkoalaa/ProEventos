using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEvento.Persistence
{
    public interface IPalestrantePersist
    {
         Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos = false);
         Task<Palestrante> GetPalestranteByIdAsync(int palestranteId, bool includeEventos = false);
         Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos = false);
    }
}
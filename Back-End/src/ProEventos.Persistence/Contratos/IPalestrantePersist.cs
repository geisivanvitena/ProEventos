using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence.Contratos
{
    // Define métodos genéricos de persistência para manipulação de entidades geral
    public interface IPalestrantePersist
    {
        //PALESTRANTES
        // Retorna todos os palestrantes com tema especifico
        Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos = false);

        // Retorna todos os palestrante
        Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos = false);

        // Retorna um palestrante específico pelo seu ID
        Task<Palestrante> GetPalestranteByIdAsync(int palestranteId, bool includeEventos = false);
    }
}
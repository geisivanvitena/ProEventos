using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence.Contratos
{
    // Define métodos genéricos de persistência para manipulação de entidades geral
    public interface IEventoPersist
    {
        //Eventos
        // Retorna todos os eventos com tema especifico
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false);

        // Retorna todos os eventos
        Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false);

        // Retorna um evento específico pelo seu ID
        Task<Evento> GetEventoByIdAsync(int eventoId, bool includePalestrantes = false);

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence.Contratos
{
    public interface IEventoPersist
    {
        Task<Evento[]> GetAllEnventosByTemaAsync(string tema, bool includePalestrantes = false);
        Task<Evento[]> GetAllEnventosAsync(bool includePalestrantes = false);
        Task<Evento> GetEnventoByIdAsync(int eventoId, bool includePalestrantes = false);
    }
}
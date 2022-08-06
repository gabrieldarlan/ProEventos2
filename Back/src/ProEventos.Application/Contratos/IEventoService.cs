using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Application.Contratos
{
    public interface IEventoService
    {
        Task<Evento> AddEventos(Evento model);
        Task<Evento> UpdateEvento(int eventoId, Evento model);
        Task<bool> Delete(int eventoId);

        Task<Evento[]> GetAllEnventosAsync(bool includePalestrantes = false);
        Task<Evento[]> GetAllEnventosByTemaAsync(string tema, bool includePalestrantes = false);
        Task<Evento> GetEnventoByIdAsync(int EventoId, bool includePalestrantes = false);
    }
}
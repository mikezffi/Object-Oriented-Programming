using System.Collections.Generic;

namespace AppSeries.Interfaces
{
    public interface IRepositorio<Temp>
    {
         List<Temp> Lista();
         Temp RetornaPorId(int id);
         void Insere(Temp entidade);
         void Exclui(int id);
         void Atualiza(int id, Temp entidade);
         int ProximoId();
    }
}
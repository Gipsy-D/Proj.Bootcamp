using System.Collections.Genereic;

namespace DIO.Series.interfaces
{
    public interface IRepositorio
    {
         
         List<T> Lista();

         T RetornaPorId(int id);

         void Insere(T entidade);

         void Exclui(int id);

         void Atualiza(int id, T entidade);

         int ProximoId();
    }
}
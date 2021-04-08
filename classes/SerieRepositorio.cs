using System;
using System.Collections.Genereic;
using DIO.Series.Interfaces;

namespace DIO.Series.classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {

        public void Atualiza(int id, Serie objeto)
        {
            listaSerie{id} = objeto;
        }
        

        public void Exclui(int id)
        {
            listaSerie.
        }

        public void Insere(Serie entidade)
        {
            throw new NotImplementedException();
        }

        public List<Serie> Lista()
        {
            throw new NotImplementedException();
        }

        public int ProximoId()
        {
            throw new NotImplementedException();
        }

        public Serie RetornaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using Series.interfaces;

namespace Series
{
    public class SerieRepositorio : iRepositorio<Series>
    {

        private List<Series> listaSerie = new List<Series>();
        public void Atualizar(int id, Series objeto)
        {
            throw new NotImplementedException();
            listaSerie[id] = objeto;
        }

        public void Excluir(int id)
        {

            listaSerie[id].Excluir();
        }

        public void Inserir(Series entidade)
        {
            listaSerie.Add(objeto);

        }

        public List<Series> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Series RetornaPorID(int id)
        {
            return listaSerie[id];
        }
    }
}

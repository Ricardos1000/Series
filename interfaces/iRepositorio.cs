using System;
using System.Collections.Generic;
using System.Text;

namespace Series.interfaces
{
    public interface iRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorID(int id);
        void Inserir(T entidade);
        void Excluir(int id);
        void Atualizar(int id, T entidade);
        int ProximoId();

    }
}

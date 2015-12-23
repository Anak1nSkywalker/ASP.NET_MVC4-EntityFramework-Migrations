using System.Collections.Generic;

namespace TiSelvagem.Dominio.contrato
{
    public interface IRepositorio<T> where T : class
    {
        void Salvar(T entidade);

        void Excluir(T entidade);

        IEnumerable<T> ListarTodos();

        T ListarPorId(string id);
    }
}

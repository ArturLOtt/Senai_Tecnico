using InLock.DatabaseFirst.Solution.Domains;
using System.Collections.Generic;

namespace InLock.DatabaseFirst.Solution.Interfaces
{
    interface IJogosRepository
    {
        List<Jogos> Listar();

        void Cadastrar(Jogos jogos);

        void Deletar(Jogos jogos);

        List<Jogos> ListaPorId();
    }
}

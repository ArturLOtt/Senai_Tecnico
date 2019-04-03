using InLock.CodeFirst.WebApi.Manha.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InLock.CodeFirst.WebApi.Manha.Interfaces
{
    public interface IJogoRepository
    {
        List<JogoDomain> Listar();

        void Cadastrar(JogoDomain jogos);

        void Deletar(JogoDomain jogos);

        JogoDomain ListaPorId(int id);

                     
    }
}

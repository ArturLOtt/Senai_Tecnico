using Senai.InLock.WebApi.Domains;
using System.Collections.Generic;

namespace Senai.InLock.WebApi.Interfaces
{
    public interface IJogosRepository
    {

        List<JogosDomain> Listar();

        // somente administrador
        void Cadastrar(JogosDomain evento);
                  
    }
}

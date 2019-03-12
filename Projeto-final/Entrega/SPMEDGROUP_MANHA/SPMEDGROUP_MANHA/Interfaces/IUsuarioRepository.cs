using SPMEDGROUP_MANHA.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMEDGROUP_MANHA.Interfaces
{
    interface IUsuarioRepository
    {

        void Cadastrar(Usuarios usuario);
        
    }
}

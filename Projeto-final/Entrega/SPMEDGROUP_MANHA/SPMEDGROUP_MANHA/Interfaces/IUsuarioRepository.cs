using SPMEDGROUP_MANHA.Domains;
using SPMEDGROUP_MANHA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMEDGROUP_MANHA.Interfaces
{
    interface IUsuarioRepository
    {

        Usuarios BuscarPorEmailESenha(LoginViewModel login);

        void Cadastrar(Usuarios usuario);
        
    }
}

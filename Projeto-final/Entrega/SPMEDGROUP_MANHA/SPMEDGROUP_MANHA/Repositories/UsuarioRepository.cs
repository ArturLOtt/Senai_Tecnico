using SPMEDGROUP_MANHA.Domains;
using SPMEDGROUP_MANHA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMEDGROUP_MANHA.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public void Cadastrar(Usuarios usuario)
        {

            using (SPMEDGROUPContext ctx = new SPMEDGROUPContext())
            {
                ctx.Usuarios.Add(usuario);
                ctx.SaveChanges();
            }

        }
    }
}

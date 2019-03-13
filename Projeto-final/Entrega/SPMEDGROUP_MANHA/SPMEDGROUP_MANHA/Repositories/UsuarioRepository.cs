using SPMEDGROUP_MANHA.Domains;
using SPMEDGROUP_MANHA.Interfaces;
using SPMEDGROUP_MANHA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMEDGROUP_MANHA.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        public Usuarios BuscarPorEmailESenha(LoginViewModel login)
        {
            using (SPMEDGROUPContext ctx = new SPMEDGROUPContext())
            {
                return ctx.Usuarios.FirstOrDefault(u => u.Email == login.Email && u.Senha == login.Senha);
            }
        }

        public List<Usuarios> Listar()
        {
            using (SPMEDGROUPContext ctx = new SPMEDGROUPContext())
            {
                return ctx.Usuarios.ToList();
            }
        }
                
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

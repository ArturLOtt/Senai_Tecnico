using InLock.DatabaseFirst.Solution.Domains;
using InLock.DatabaseFirst.Solution.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InLock.DatabaseFirst.Solution.Repositories
{
    public class JogosRepository : IJogosRepository
    {
        public void Cadastrar(Jogos jogo)
        {
            using (InLockContext ctx = new InLockContext())
            {
                ctx.Jogos.Add(jogo);
                ctx.SaveChanges();
            }
        }

        public void Deletar(Jogos jogos)
        {
            throw new NotImplementedException();
        }

        public List<Jogos> ListaPorId()
        {
            List<Jogos> jogosLista = new List<Jogos>();
            using (InLockContext ctx = new InLockContext())
            {
                return ctx.Jogos.ToList();
            }
        }

        public List<Jogos> Listar()
        {
            List<Jogos> jogosLista = new List<Jogos>();
            using (InLockContext ctx = new InLockContext())
            {
               return ctx.Jogos.ToList();
                //ctx.Jogos.Add();
                //ctx.SaveChanges();
            }
        }
    }
}

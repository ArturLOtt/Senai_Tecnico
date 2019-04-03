using InLock.CodeFirst.WebApi.Manha.Context;
using InLock.CodeFirst.WebApi.Manha.Domains;
using InLock.CodeFirst.WebApi.Manha.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InLock.CodeFirst.WebApi.Manha.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        public void Cadastrar(JogoDomain jogos)
        {
            using (InLockContext ctx = new InLockContext())
            {
                ctx.Jogos.Add(jogos);
                ctx.SaveChanges();
            }
        }

        public void Deletar(JogoDomain jogos)
        {
            throw new NotImplementedException();
        }

        public JogoDomain ListaPorId(int id)
        {
            using (InLockContext ctx = new InLockContext())
            {

                return ctx.Jogos.Find(id);
                
            }

        }

        public List<JogoDomain> Listar()
        {
            List<JogoDomain> jogosLista = new List<JogoDomain>();
            using (InLockContext ctx = new InLockContext())
            {
                return ctx.Jogos.ToList();
            }
        }
                                            
        }
    }

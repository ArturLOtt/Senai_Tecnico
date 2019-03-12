using SPMEDGROUP_MANHA.Domains;
using SPMEDGROUP_MANHA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMEDGROUP_MANHA.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        public void Cadastrar(Consulta consulta)
        {
            using (SPMEDGROUPContext ctx = new SPMEDGROUPContext())
            {
                ctx.Consulta.Add(consulta);
                ctx.SaveChanges();
            }
        }

        public List<Consulta> Listar()
        {
            List<Consulta> jogosLista = new List<Consulta>();
            using (SPMEDGROUPContext ctx = new SPMEDGROUPContext())
            {
                return ctx.Consulta.ToList();
            }
        }

        public List<Consulta> ListarPorIdMedico()
        {
            List<Consulta> jogosLista = new List<Consulta>();
            using (SPMEDGROUPContext ctx = new SPMEDGROUPContext())
            {
                return ctx.Consulta.ToList();
            }
        }

        public List<Consulta> ListarPorIdPaciente()
        {
            List<Consulta> jogosLista = new List<Consulta>();
            using (SPMEDGROUPContext ctx = new SPMEDGROUPContext())
            {
                return ctx.Consulta.ToList();
            }
        }

        public void ModificarDescricao(Consulta consulta)
        {
            using (SPMEDGROUPContext ctx = new SPMEDGROUPContext())
            {
                ctx.Consulta.Update(consulta);
                ctx.SaveChanges();
            }
        }
    }
}

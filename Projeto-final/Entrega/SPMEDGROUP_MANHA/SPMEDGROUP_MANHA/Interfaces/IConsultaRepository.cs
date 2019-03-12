using SPMEDGROUP_MANHA.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMEDGROUP_MANHA.Interfaces
{
    interface IConsultaRepository
    {
        List<Consulta> Listar();

        void Cadastrar(Consulta consulta);

        void ModificarDescricao(Consulta consulta);

        List<Consulta> ListarPorIdMedico();

        List<Consulta> ListarPorIdPaciente();

    }
}

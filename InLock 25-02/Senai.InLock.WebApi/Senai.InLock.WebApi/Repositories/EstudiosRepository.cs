using Senai.InLock.WebApi.Domains;
using Senai.InLock.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Senai.InLock.WebApi.Repositories
{
    public class EstudiosRepository : IEstudiosRepository
    {
        private string StringConexao = "Data Source=.\\SqlExpress; initial catalog=InLock_Games_Manha; integrated security=true";

        public List<EstudiosDomain> Listar()
        {
            string QuerySelect = @"SELECT * FROM ESTUDIOS LEFT JOIN JOGOS ON ESTUDIOS.ESTUDIOID = JOGOS.ESTUDIOID";

            List<EstudiosDomain> estudioLista = new List<EstudiosDomain>();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                con.Open();

                SqlDataReader sdr;

                using (SqlCommand cmd = new SqlCommand(QuerySelect, con))
                {
                    sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        EstudiosDomain estudio = new EstudiosDomain
                        {
                            Id = Convert.ToInt32(sdr["ESTUDIOID"]),
                            NomeEstudio = sdr["NOMEESTUDIO"].ToString()
                          
                        };

                        estudioLista.Add(estudio);
                    }
                }
            }

            return estudioLista;
               
        }
    }
}

using Senai.InLock.WebApi.Domains;
using Senai.InLock.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Senai.InLock.WebApi.Repositories
{
    public class JogosRepository : IJogosRepository
    {
        private string StringConexao = "Data Source=.\\SqlExpress; initial catalog=InLock_Games_Manha; user id=sa, pwd=132 ";
        
        public void Cadastrar(JogosDomain cadastro)
        {
            string QueryInsert = "INSERT INTO JOGOS (NOMEJOGO, DESCRICAO, DATALANCAMENTO, VALOR, ESTUDIOID) " +
               " VALUES (@NOMEJOGO, @DESCRICAO, @DATALANCAMENTO, @VALOR, @ESTUDIOID)";

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                using (SqlCommand cmd = new SqlCommand(QueryInsert, con))
                {
                    cmd.Parameters.AddWithValue("@NOMEJOGO", cadastro.NomeJogo);
                    cmd.Parameters.AddWithValue("@DESCRICAO", cadastro.Descricao);
                    cmd.Parameters.AddWithValue("@DATALANCAMENTO", cadastro.DataLancamento);
                    cmd.Parameters.AddWithValue("@VALOR", cadastro.Valor);
                    cmd.Parameters.AddWithValue("@ESTUDIOID", cadastro.EstudioId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<JogosDomain> Listar()
        {
            string QuerySelect = @"SELECT * FROM JOGOS INNER JOIN ESTUDIOS ON JOGOS.ESTUDIOID = ESTUDIOS.ESTUDIOID";

            List<JogosDomain> jogosLista = new List<JogosDomain>();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                con.Open();

                SqlDataReader sdr;
                        
                using (SqlCommand cmd = new SqlCommand(QuerySelect, con))
                {
                    sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        JogosDomain jogos = new JogosDomain
                        {
                            Id = Convert.ToInt32(sdr["ID"]),
                            NomeJogo = sdr["NOMEJOGO"].ToString(),
                            Descricao = sdr["DESCRICAO"].ToString(),
                            DataLancamento = Convert.ToDateTime(sdr["DATALANCAMENTO"].ToString()),
                            Valor = Convert.ToDouble(sdr["VALOR"]),
                            EstudioId = Convert.ToInt32(sdr["ESTUDIOID"]),
                            Estudio = new EstudiosDomain
                            {
                                Id = Convert.ToInt32(sdr["ESTUDIOID"]),
                                NomeEstudio = sdr["NOMEESTUDIO"].ToString()
                            }

                        };

                        jogosLista.Add(jogos);
                    }
                }
            }

            return jogosLista;
                                                                                    
        }
                  
    }
}

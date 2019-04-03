using Senai.InLock.WebApi.Domains;
using Senai.InLock.WebApi.Interfaces;
using System;
using System.Data.SqlClient;

namespace Senai.InLock.WebApi.Repositories
{

    public class UsuarioRepository : IUsuarioRepository
    {


        private string StringConexao = "Data Source=.\\SqlExpress;" +
            "initial catalog=InLock_Games_Manha;" +
            "integrated security=true";

        public UsuarioDomain BuscarPorEmailSenha(string email, string senha)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string QuerySelect = "SELECT ID, NOME, EMAIL, SENHA, TIPO_USUARIO FROM USUARIOS " +
                                                         "WHERE EMAIL = @EMAIL AND SENHA =@SENHA";

                using (SqlCommand cmd = new SqlCommand(QuerySelect, con))
                {
                    cmd.Parameters.AddWithValue("@EMAIL", email);
                    cmd.Parameters.AddWithValue("@SENHA", senha);

                    con.Open();

                    SqlDataReader sdr = cmd.ExecuteReader();

                    if (sdr.HasRows)
                    {
                        UsuarioDomain usuario = new UsuarioDomain();

                        while (sdr.Read())
                        {
                            usuario.Id = Convert.ToInt32(sdr["ID"]);
                            usuario.Nome = sdr["NOME"].ToString();
                            usuario.Email = sdr["EMAIL"].ToString();
                            usuario.TipoUsuario = sdr["TIPO_USUARIO"].ToString();
                        }

                        return usuario;
                    }
                }
                return null;
            }

        }

        //UsuarioDomain IUsuarioRepository.BuscarPorEmailSenha(string email, string senha)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

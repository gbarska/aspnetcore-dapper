using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Dapper;

namespace APIIndicadores
{
    public class IndicadoresDAO
    {
        private IConfiguration _configuration;

        public IndicadoresDAO(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Indicador Obter(string codIndicador)
        {
            using (SqlConnection conexao = new  SqlConnection(
                _configuration.GetConnectionString("BaseIndicadores")))
                {
                    return conexao.QueryFirstOrDefault<Indicador>
                    (
                        "SELECT Sigla, NomeIndicador, UltimaAtualizacao, Valor " +
                        "FROM dbo.Indicadores " +
                        "WHERE Sigla = @CodIndicador ",
                        new { CodIndicador = codIndicador }
                    );
                }
        }
                
 
    }
}
using Dapper;
using DevTestApi.Domain;
using DevTestApi.Interfaces;
using System.Data.SqlClient;

namespace DevTestApi.Data
{
    public class CadTesteRepository : ICadTesteRepository
    {
       private const string connectionString = "Data Source=WINAPZLX4J5BOX8;Initial Catalog=DEV_TESTE;Integrated Security=True";
        public async Task<bool> Create(CadTeste cadTeste)
        {
            await using (var connection = new SqlConnection(connectionString))
            {
                var retorno = await connection.ExecuteAsync("INSERT INTO CadTeste VALUES(@Nome,@Email,@Cidade)", 
                    new { Nome = cadTeste.Nome, Email = cadTeste.Email, Cidade = cadTeste.Cidade }).ConfigureAwait(false);
                return retorno > 0;
            }
        }

        public async Task<bool> Delete(int id)
        {
            await using (var connection = new SqlConnection(connectionString))
            {
                var retorno = await connection.ExecuteAsync("DELETE FROM CadTeste Where Id = @id", new { Id = id }).ConfigureAwait(false);
                return retorno > 0;

            }
        }

        public async Task<List<CadTeste>> GetAll()
        {
            await using (var connection = new SqlConnection(connectionString))
            {
                return (await connection.QueryAsync<CadTeste>("Select Id, Nome, Email, Cidade FROM CadTeste").ConfigureAwait(false)).AsList();
            }
        }

        public async Task<bool> Update(CadTeste cadTeste)
        {
            await using (var connection = new SqlConnection(connectionString))
            {
                var retorno = await connection.ExecuteAsync("UPDATE CadTeste SET Nome = @Nome WHERE Id = @id", new { Id = cadTeste.Id, Nome = cadTeste.Nome, Email = cadTeste.Email, Cidade = cadTeste.Cidade }).ConfigureAwait(false);
                return retorno > 0;

            }
        }
    }
}

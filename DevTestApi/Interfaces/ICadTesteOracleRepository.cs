using DevTestApi.Domain;

namespace DevTestApi.Interfaces
{
    public interface ICadTesteOracleRepository
    {
        Task<List<CadTeste>> GetAll();
        Task<bool> Create(CadTeste cadTeste);
        Task<bool> Update(CadTeste cadTeste);
        Task<bool> Delete(int id);
    }
}

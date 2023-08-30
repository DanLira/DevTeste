namespace DevTestApi.Domain
{
    public class CadTeste
    {
        public CadTeste(string nome, string email, string cidade)
        {
            Nome = nome;
            Email = email;
            Cidade = cidade;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public string Cidade { get; set; }
    }
}

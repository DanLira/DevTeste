namespace DevTestApi.Domain.Commands.Responses
{
    public class CreateCadTesteResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public string Cidade { get; set; }
    }
}

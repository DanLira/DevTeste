using DevTestApi.Domain.Commands.Responses;
using MediatR;

namespace DevTestApi.Domain.Commands.Requests
{
    public class CreateCadTesteRequest : IRequest<CreateCadTesteResponse>
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public string Cidade { get; set; }
    }
}

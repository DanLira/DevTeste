using DevTestApi.Domain.Commands.Requests;
using DevTestApi.Domain.Commands.Responses;
using DevTestApi.Interfaces;
using MediatR;

namespace DevTestApi.Domain.Handlers
{
    public class CreateCadTesteHandler : IRequestHandler<CreateCadTesteRequest, CreateCadTesteResponse>
    {

        ICadTesteRepository _repository;
        ICadTesteOracleRepository _repositoryOracle;

        public CreateCadTesteHandler(ICadTesteRepository repository, ICadTesteOracleRepository repositoryOracle)
        {
            _repository = repository;
            _repositoryOracle = repositoryOracle;
        }

        public Task<CreateCadTesteResponse> Handle(CreateCadTesteRequest request, CancellationToken cancellationToken)
        {

            var cadTeste = new CadTeste(request.Nome, request.Email, request.Cidade);

            _repository.Create(cadTeste);
            _repositoryOracle.Create(cadTeste);

          
            var result = new CreateCadTesteResponse
            {
                Id = cadTeste.Id,
                Nome = cadTeste.Nome,
                Email = cadTeste.Email,
                Cidade = cadTeste.Cidade
            };
            return Task.FromResult(result);
        }
    }
}

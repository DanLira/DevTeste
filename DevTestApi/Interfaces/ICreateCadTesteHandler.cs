using DevTestApi.Domain.Commands.Requests;
using DevTestApi.Domain.Commands.Responses;

namespace DevTestApi.Interfaces
{
    public interface ICreateCadTesteHandler
    {
        CreateCadTesteResponse Handle(CreateCadTesteRequest command);
    }
}

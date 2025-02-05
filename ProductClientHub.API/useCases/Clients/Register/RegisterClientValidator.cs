using FluentValidation;
using ProductClientHub.Comunication.Requests;

namespace ProductClientHub.API.useCases.Clients.Register
{
    public class RegisterClientValidator: AbstractValidator<RequestClientJson>
    {
        public RegisterClientValidator()
        {
            RuleFor(client => client.Name).NotEmpty().WithMessage("O nome não pode ser vazio.");
            RuleFor(client => client.Email).EmailAddress().WithMessage("O email não é valido.");
        }
    }
}

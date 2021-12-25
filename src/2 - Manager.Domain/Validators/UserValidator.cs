using FluentValidation;
using Manager.Domain.Entities;

namespace Manager.Domain.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x)
                    .NotEmpty()
                    .WithMessage("A entidade não pode ser vazia")

                    .NotNull()
                    .WithMessage("A entidade não pode ser nula");

            RuleFor(x => x.Name)
                    .NotEmpty()
                    .WithMessage("O Nome não pode ser vazio")

                    .NotNull()
                    .WithMessage("O Nome não pode ser nulo");

            RuleFor(x => x.Password)
                    .NotEmpty()
                    .WithMessage("A Senha não pode ser vazia")

                    .NotNull()
                    .WithMessage("A Senha não pode ser nula")

                    .MinimumLength(6)
                    .WithMessage("Mínimo de 6 caracteres para senha")

                    .MaximumLength(15)
                    .WithMessage("Máximo de 15 caracteres para senha");

            RuleFor(x => x.Email)
                    .NotEmpty()
                    .WithMessage("O Email não pode ser vazio")

                    .NotNull()
                    .WithMessage("O Email não pode ser nulo")

                    .MinimumLength(10)
                    .WithMessage("Mínimo de 10 caracteres para o Email")

                    .MaximumLength(180)
                    .WithMessage("Máximo de 80 caracteres para o Email")

                    .Matches(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
                    .WithMessage("O email informado não é válido.");


        }
    }
}
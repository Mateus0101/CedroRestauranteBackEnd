namespace RestauranteMaster.Domain.Commands.RetauranteCommand
{
    public class RegisterRestauranteCommand
    {
        public RegisterRestauranteCommand(string nome)
        {
            this.Nome = nome;
        }

        public string Nome { get; private set; }

    }
}

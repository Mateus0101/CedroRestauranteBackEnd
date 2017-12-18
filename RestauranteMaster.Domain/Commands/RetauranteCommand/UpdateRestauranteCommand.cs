namespace RestauranteMaster.Domain.Commands.RetauranteCommand
{
    public class UpdateRestauranteCommand
    {
        public UpdateRestauranteCommand(int id, string nome)
        {
            this.RestauranteId = id;
            this.Nome = nome;
        }

        public int RestauranteId { get; set; }
        public string Nome { get; private set; }
    }
}

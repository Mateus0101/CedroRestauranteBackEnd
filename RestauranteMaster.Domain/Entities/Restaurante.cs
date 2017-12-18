using System.Collections.Generic;
using RestauranteMaster.Domain.Scopes;

namespace RestauranteMaster.Domain.Entities
{
    public class Restaurante
    {
        public Restaurante()
        {

        }
        public Restaurante(string nome)
        {
            this.Nome = nome;

            this.Prato = new List<Prato>();
        }

        public int RestauranteId { get; set; }

        public string Nome { get; private set; }

        public virtual ICollection<Prato> Prato { get; set; }

        public void RegisterRestaurante() => this.CreateRestauranteScopIsValid();
        public void UpdateRestaurante(string nome)
        {
            if (!this.UpdateRestauranteScopIsValid(nome))
                return;

            this.Nome = nome;
        }
    }
}

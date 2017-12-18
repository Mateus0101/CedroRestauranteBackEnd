using RestauranteMaster.Domain.Entities;
using RestauranteMaster.SharedKernel.Validation;

namespace RestauranteMaster.Domain.Scopes
{
    public static class RestauranteScopes
    {
        public static bool CreateRestauranteScopIsValid(this Restaurante restaurante)
        {
            return AssertionConcern.IsSatisfiedBy(
                AssertionConcern.AssertNotEmpty(restaurante.Nome, "O campo nome é Obrigatório!")
                );
        }
        public static bool UpdateRestauranteScopIsValid(this Restaurante restaurante, string nome)
        {
            return AssertionConcern.IsSatisfiedBy(
                AssertionConcern.AssertNotEmpty(nome, "O campo nome é Obrigatório!")
                );
        }
    }
}

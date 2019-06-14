using GraphQL.Types;
using GraphQLExample.StarWars.Data;
using GraphQLExample.StarWars.InputTypes;
using GraphQLExample.StarWars.Mutations;
using GraphQLExample.StarWars.Queries;
using GraphQLExample.StarWars.Types;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace GraphQLExample.StarWars
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddStarWarsGraphQL(this IServiceCollection services)
        {
            services.TryAddSingleton<StarWarsService>();
            services.TryAddSingleton<StarWarsQuery>();
            services.TryAddSingleton<StarWarsMutation>();
            services.TryAddSingleton<CharacterType>();
            services.TryAddSingleton<EpisodeType>();
            services.TryAddSingleton<HumanType>();
            services.TryAddSingleton<HumanInputType>();
            services.TryAddSingleton<DroidType>();

            services.TryAddSingleton<ISchema, StarWarsSchema>();

            return services;
        }
    }
}

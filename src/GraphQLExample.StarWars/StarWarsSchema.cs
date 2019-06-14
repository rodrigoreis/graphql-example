using GraphQL;
using GraphQL.Types;
using GraphQLExample.StarWars.Mutations;
using GraphQLExample.StarWars.Queries;

namespace GraphQLExample.StarWars
{
    public class StarWarsSchema : Schema
    {
        public StarWarsSchema(IDependencyResolver dependencyResolver)
            : base(dependencyResolver)
        {
            Query = dependencyResolver.Resolve<StarWarsQuery>();
            Mutation = dependencyResolver.Resolve<StarWarsMutation>();
        }
    }
}

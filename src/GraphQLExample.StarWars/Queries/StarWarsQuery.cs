using GraphQL.Types;
using GraphQLExample.StarWars.Data;
using GraphQLExample.StarWars.Types;

namespace GraphQLExample.StarWars.Queries
{
    public class StarWarsQuery : ObjectGraphType<object>
    {
        public StarWarsQuery(StarWarsService service)
        {
            Name = "Query";

            Field<CharacterType>("hero", resolve: context => service.GetHumanByIdAsync("1"));

            Field<HumanType>(
                "human",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "id", Description = "id of the human" }
                ),
                resolve: context => service.GetHumanByIdAsync(context.GetArgument<string>("id"))
            );

            Field<DroidType>(
                "droid",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "id", Description = "id of the droid" }
                ),
                resolve: context => service.GetDroidByIdAsync(context.GetArgument<string>("id"))
            );
        }
    }
}

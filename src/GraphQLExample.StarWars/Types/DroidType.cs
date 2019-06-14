using GraphQL.Types;
using GraphQLExample.StarWars.Data;
using GraphQLExample.StarWars.Data.Domain;

namespace GraphQLExample.StarWars.Types
{
    public class DroidType : ObjectGraphType<Droid>
    {
        public DroidType(StarWarsService service)
        {
            Name = "Droid";

            Interface<CharacterType>();

            Description = "A human character in the Star Wars universe.";

            Field(d => d.Id).Description("The id of the droid.");

            Field(d => d.Name, nullable: true).Description("The name of the droid.");

            Field<ListGraphType<CharacterType>>(
                "friends",
                resolve: context => service.GetFriends(context.Source)
            );

            Field<ListGraphType<EpisodeType>>("appearsIn", "Which movie they appear in.");

            Field(d => d.PrimaryFunction, nullable: true).Description("The primary function of the droid.");
        }
    }
}

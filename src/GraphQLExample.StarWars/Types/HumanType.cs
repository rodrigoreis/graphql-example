using GraphQL.Types;
using GraphQLExample.StarWars.Data;
using GraphQLExample.StarWars.Data.Domain;

namespace GraphQLExample.StarWars.Types
{
    public class HumanType : ObjectGraphType<Human>
    {
        public HumanType(StarWarsService service)
        {
            Name = "Human";

            Interface<CharacterType>();

            Description = "A mechanical creature in the Star Wars universe.";

            Field(h => h.Id).Description("The id of the human.");

            Field(h => h.Name, nullable: true).Description("The name of the human.");

            Field<ListGraphType<CharacterType>>(
                "friends",
                resolve: context => service.GetFriends(context.Source)
            );

            Field<ListGraphType<EpisodeType>>("appearsIn", "Which movie they appear in.");

            Field(h => h.HomePlanet, nullable: true).Description("The home planet of the human.");
        }
    }
}

using GraphQL.Types;
using GraphQLExample.StarWars.Data.Domain;

namespace GraphQLExample.StarWars.Types
{
    public class CharacterType : InterfaceGraphType<Character>
    {
        public CharacterType()
        {
            Name = "Character";
            Field(d => d.Id).Description("The id of the character.");
            Field(d => d.Name, nullable: true).Description("The name of the character.");
            Field<ListGraphType<CharacterType>>("friends");
            Field<ListGraphType<EpisodeType>>("appearsIn", "Which movie they appear in.");
        }
    }
}

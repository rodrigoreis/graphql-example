using GraphQL.Types;
using GraphQLExample.StarWars.Data.Domain;

namespace GraphQLExample.StarWars.InputTypes
{
    public class HumanInputType : InputObjectGraphType<Human>
    {
        public HumanInputType()
        {
            Name = "HumanInput";

            Field(x => x.Name);

            Field(x => x.HomePlanet, nullable: true);
        }
    }
}

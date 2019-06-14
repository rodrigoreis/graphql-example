using GraphQL.Types;

namespace GraphQLExample.StarWars.Types
{
    public class EpisodeType : EnumerationGraphType
    {
        public EpisodeType()
        {
            Name = "Episode";
            Description = "One of the films in the Star Wars Trilogy.";
            AddValue("PHANTOM", "Released in 1999.", 1);
            AddValue("CLONE", "Released in 2002.", 2);
            AddValue("SITH", "Released in 2005.", 3);
            AddValue("NEWHOPE", "Released in 1977.", 4);
            AddValue("EMPIRE", "Released in 1980.", 5);
            AddValue("JEDI", "Released in 1983.", 6);
            AddValue("AWAKENS", "Released in 2015.", 7);
            AddValue("LASTJEDI", "Released in 2017.", 8);
            AddValue("SKYWALKER", "Released in 2017.", 8);
        }
    }
}

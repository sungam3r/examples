using GraphQL.Types;

namespace StarWars.Types
{
    public class EpisodeEnum : EnumerationGraphType
    {
        public EpisodeEnum()
        {
            Name = "Episode";
            Description = "One of the films in the Star Wars Trilogy.";
            AddValue("NEWHOPE", "Released in 1977.", 4);
            AddValue("EMPIRE", "Released in 1980.", 5);
            AddValue("JEDI", "Released in 1983.", 6);
        }
    }

    public enum Episodes
    {
        NEWHOPE  = 4,
        EMPIRE  = 5,
        JEDI  = 6
    }

    public class EpisodeEnum1 : EnumerationGraphType
    {
        public EpisodeEnum1()
        {
            Name = "Episode1";
            Description = "One of the films in the Star Wars Trilogy.";
            AddValue("NEWHOPE1", "Released in 1977.", 4);
            AddValue("EMPIRE1", "Released in 1980.", 5);
            AddValue("JEDI1", "Released in 1983.", 6);
        }
    }
}

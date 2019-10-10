using GraphQL.Types;
using StarWars.Types;

namespace StarWars
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

    public class HumanInputType1 : InputObjectGraphType<Human>
    {
        public HumanInputType1()
        {
            Name = "HumanInput1";
            Field(x => x.Name);
            Field(x => x.HomePlanet, nullable: true);
        }
    }
}

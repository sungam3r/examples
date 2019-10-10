using GraphQL.Types;
using GraphQL.Utilities;
using System;

namespace StarWars
{
    public class StarWarsSchema : Schema
    {
        public StarWarsSchema(IServiceProvider provider)
            : base(provider)
        {
            Query = provider.GetRequiredService<StarWarsQuery>();
            Mutation = provider.GetRequiredService<StarWarsMutation>();
        }
    }

    public class StarWarsSchema1 : Schema
    {
        public StarWarsSchema1(IServiceProvider provider)
            : base(provider)
        {
            Query = provider.GetRequiredService<StarWarsQuery1>();
            Mutation = provider.GetRequiredService<StarWarsMutation1>();
        }
    }
}

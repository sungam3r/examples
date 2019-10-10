using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using StarWars;
using StarWars.Types;

namespace Example
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<StarWarsData>();
            services.AddSingleton<StarWarsQuery>();
            services.AddSingleton<StarWarsMutation>();
            services.AddSingleton<HumanType>();
            services.AddSingleton<HumanInputType>();
            services.AddSingleton<DroidType>();
            services.AddSingleton<CharacterInterface>();
            services.AddSingleton<EpisodeEnum>();
            services.AddSingleton<StarWarsSchema>();

            services.AddSingleton<StarWarsQuery1>();
            services.AddSingleton<StarWarsMutation1>();
            services.AddSingleton<HumanType1>();
            services.AddSingleton<HumanInputType1>();
            services.AddSingleton<DroidType1>();
            services.AddSingleton<CharacterInterface1>();
            services.AddSingleton<EpisodeEnum1>();
            services.AddSingleton<StarWarsSchema1>();

            services.AddLogging(builder => builder.AddConsole());
            services.AddHttpContextAccessor();

            services.AddGraphQL(_ =>
            {
                _.EnableMetrics = true;
                _.ExposeExceptions = true;
            })
            .AddUserContextBuilder(httpContext => new GraphQLUserContext { User = httpContext.User });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseGraphQL<StarWarsSchema>("/s1");
            app.UseGraphQL<StarWarsSchema1>("/s2");

            // use graphql-playground at default url /ui/playground
            app.UseGraphQLPlayground();
        }
    }
}

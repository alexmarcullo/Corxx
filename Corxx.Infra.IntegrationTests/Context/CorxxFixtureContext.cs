using Corxx.Infra.Data;
using System.Configuration;

namespace Corxx.Infra.IntegrationTests.Context
{
    public class CorxxFixtureContext
    {
        public readonly CorxxDataContext context;
        public CorxxFixtureContext()
        {
            var connectionStrings = ConfigurationManager.ConnectionStrings["corxx"].ConnectionString;
            context = new CorxxDataContext(connectionStrings);
        }
    }
}

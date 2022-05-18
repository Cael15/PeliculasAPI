using Microsoft.AspNetCore.Authorization;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasAPI.Tests
{
    public class AllowAnonymousHandler: IAuthorizationHandler
    {
        public Task HandleAsync(AuthorizationHandlerContext context)
        {
            foreach (var reqeuriment in context.PendingRequirements.ToList())
            {
                context.Succeed(reqeuriment);
            }

            return Task.CompletedTask;
        }

    }
}

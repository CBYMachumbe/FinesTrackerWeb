using BusinessLogic.IService;
using BusinessLogic.Services;
using Microsoft.Extensions.DependencyInjection;


namespace BusinessLogic.DependencyInjection
{
    public static class BusinessLogicModuleStartup
    {
        public static void AddBusinessLogic(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IFinesService, FinesService>();
            serviceCollection.AddScoped<IUserService, UserService>();
            serviceCollection.AddScoped<IFinePostService, FinePostService>();
            serviceCollection.AddScoped<IVotesService, VoteService>();
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using Persistence.IRepositories;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.DependencyInjection
{
   public static class PersistenceModuleStartup
    {
        public static void AddPersistence(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IFinesRepository, FineRepository>();
            serviceCollection.AddScoped<IFinePostsRepository, FinePostsRepository>();
            serviceCollection.AddScoped<IUserRepository, UserRepository>();
            serviceCollection.AddScoped<IVotesRepository, VotesRepository>();
        }
    }
}

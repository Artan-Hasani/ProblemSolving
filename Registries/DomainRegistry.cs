using Microsoft.Extensions.DependencyInjection;
using ProblemSolving.LeetCodeSolutions.TwoSumProblem;
using ProblemSolving.Services;
using ProblemSolving.Strategy;

namespace ProblemSolving.Registries
{
    public static class DomainRegistry
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            services.AddSingleton(new TwoSumProblemInput(new int[] { 2, 7, 11, 15 }, 9));
            services.AddTransient<IProblemSolution, TwoSumProblem>();
            services.AddSingleton<CallProblemSolutionService>();

            return services;
        }
    }
}



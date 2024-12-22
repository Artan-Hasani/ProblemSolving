using Microsoft.Extensions.DependencyInjection;
using ProblemSolving.Registries;
using ProblemSolving.Services;

class Program
{
    static void Main(string[] args)
    {
        var serviceCollection = new ServiceCollection();

        serviceCollection.AddDomainServices();

        var serviceProvider = serviceCollection.BuildServiceProvider();

        var executeSolution = serviceProvider.GetRequiredService<CallProblemSolutionService>();
        executeSolution.DetectAndCallSolution();
    }
}
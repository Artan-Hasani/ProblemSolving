using ProblemSolving.Strategy;
using Spectre.Console;

namespace ProblemSolving.Services
{
    public class CallProblemSolutionService
    {
        private readonly IEnumerable<IProblemSolution> _solutions;

        public CallProblemSolutionService(IEnumerable<IProblemSolution> solutions)
        {
            _solutions = solutions;
        }

        public void DetectAndCallSolution()
        {
            while (true)
            {
                var choice = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Choose an option:")
                    .PageSize(100)
                    .AddChoices(new[] {
                            ProblemSolutionEnums.TwoSumProblem.ToString(),
                            "Exit"
                    }));

                if (Enum.GetNames(typeof(ProblemSolutionEnums)).Contains(choice))
                {
                    var solution =  _solutions.FirstOrDefault(s => s.For(Enum.Parse<ProblemSolutionEnums>(choice)));
                    if(solution != null) 
                    {
                        solution.Execute();
                    }
                    continue;
                }

                if(choice == "Exit")
                {
                    AnsiConsole.MarkupLine("[green]Exiting...[/]");
                    return;
                }
            }
        }
    }
}

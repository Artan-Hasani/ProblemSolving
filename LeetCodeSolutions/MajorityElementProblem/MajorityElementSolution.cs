using ProblemSolving.Strategy;

namespace ProblemSolving.LeetCodeSolutions.MajorityElementProblem
{
    public class MajorityElementSolution : IProblemSolution
    {
        MajorityElementInputs _inputs;

        public MajorityElementSolution(MajorityElementInputs inputs)
        {
            _inputs = inputs;
        }

        public void Execute()
        {
            var result = _inputs.nums.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
            Console.WriteLine("Result is: " + result);
        }

        public bool For(ProblemSolutionEnums problemSolution)
        {
            return problemSolution == ProblemSolutionEnums.MajorityElement;
        }
    }
}

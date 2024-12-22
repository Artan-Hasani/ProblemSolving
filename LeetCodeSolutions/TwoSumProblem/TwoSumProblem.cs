using ProblemSolving.Strategy;

namespace ProblemSolving.LeetCodeSolutions.TwoSumProblem
{
    public class TwoSumProblem : IProblemSolution
    {
        private readonly TwoSumProblemInput _input;

        public TwoSumProblem(TwoSumProblemInput input)
        {
            _input = input;
        }

        public void Execute()
        {
            var complements = new Dictionary<int, int>();

            for (var i = 0; i < _input.Nums.Length; i++)
            {
                var complement = _input.Target - _input.Nums[i];

                if (complements.ContainsKey(complement))
                {
                    var result = new int[] { complements[complement], i };
                    Console.WriteLine("Solution: " + result[0] + " " + result[1]);
                    break;
                }
                complements[_input.Nums[i]] = i;
            }
        }

        public bool For(ProblemSolutionEnums problemSolution)
        {
            return problemSolution == ProblemSolutionEnums.TwoSumProblem;
        }
    }
}

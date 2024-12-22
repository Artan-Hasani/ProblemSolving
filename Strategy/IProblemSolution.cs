namespace ProblemSolving.Strategy
{
    public interface IProblemSolution
    {
        public void Execute();

        public bool For(ProblemSolutionEnums problemSolution);
    }
}

using BranchesExtension.Dto;
using System.Collections.Generic;

namespace BranchesExtension.Strategy
{
    public class GitComputeContext
    {
        private IGitComputeStrategy Strategy { get; set; }

        public GitComputeContext(IGitComputeStrategy strategy)
        {
            Strategy = strategy;
        }

        public List<CommitDto> CommitsComputation(
            string pathToRepo, string pathToUrl
        )
        {
            return Strategy?.GetCommits(pathToRepo, pathToUrl);
        }

        public ProjectInfoDto ProjectComputation(
            List<CommitDto> commits
        )
        {
            return Strategy?.GetProjectInfo(commits);
        }
    }
}
